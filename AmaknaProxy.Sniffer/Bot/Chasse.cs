using AmaknaProxy.API.Managers;
using AmaknaProxy.API.Protocol.Messages;
using AmaknaProxy.API.Protocol.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using static AmaknaProxy.Sniffer.Bot.Chasse;
using MapPositions = AmaknaProxy.Sniffer.Bot.Chasse.MapPositions;

namespace AmaknaProxy.Sniffer.Bot
{
    public class ChasseDetail
    {
        public MapPositions? currentStartMap; // Contient la map de depart de l'indice courant
        public string direction;
        public typeIndiceEnum? typeIndice;
        public uint? idIndice; // Si type == phorreur -> id phorreur sinon id de l'indice
        public int nbCurrentFlag;
        public hintFinder.HintMap? positionIndice { get; set; }
    }

    public class Chasse
    {
        #region Structures
        public struct MapPositions
        {
            public double id;
            public string posX;
            public string posY;
        }

        public struct PointOfInterestLabel
        {
            public uint id;
            public string label;
        }
        #endregion

        #region enums
        public enum typeIndiceEnum
        {
            PHORREUR,
            INDICE
        }
        #endregion

        public bool gIsActive { get; set; } // Si false, le bot chasse ne sera pas actif
        public InteractionsUI.userSettings? gUserSettings { get; set; }
        public List<MapPositions> gListeMapsPositions { get; set; } // correspondances mapId -> Coordonées X/Y
        public List<PointOfInterestLabel> gListeLabelPOI { get; set; } // Contient les libellé de chaque POI
        public ChasseDetail gChasseEnCours { get; set; } // Contient le detail de la chasse en cours
        public hintFinder gObjHintFinder { get; set; }
        public MapPositions gCurrentPlayerPosition { get; set; }

        // Constructeur
        public Chasse()
        {
            // Chargement du parametrage utilisateur
            gUserSettings = InteractionsUI.getUserCurseursRegistre();

            gIsActive = gUserSettings == null ? false : true;
            gChasseEnCours = null;

            // ** Chargement des fichiers JSON **
            // Chargement des correspondances mapId -> Coordonées X/Y
            WindowManager.MainWindow.Logger.Info("Chargement des correspondances mapId -> Coordonées X/Y");

            using (StreamReader r = new StreamReader("Json/MapPositions.json"))
            {
                string json = r.ReadToEnd();
                gListeMapsPositions = JsonConvert.DeserializeObject<List<MapPositions>>(json);//Contient toutes les maps en fonction de l'id
            }

            WindowManager.MainWindow.Logger.Info(gListeMapsPositions.Count() + " maps trouvées");

            // Chargement des POIs et de leurs libelles
            WindowManager.MainWindow.Logger.Info("Chargement des indices connus");

            using (StreamReader r = new StreamReader("Json/idToLibellePOI.json"))
            {
                string json = r.ReadToEnd();
                gListeLabelPOI = JsonConvert.DeserializeObject<List<PointOfInterestLabel>>(json);//Contient tous les indices de chasses (POI) id + libelle
            }

            // Init hint finder
           gObjHintFinder = new hintFinder();

            WindowManager.MainWindow.Logger.Info(gListeLabelPOI.Count() + " indices trouvés");
        }

        public MapPositions getPosFromMapId(double pMapId)
        {
            MapPositions objMapPosition = gListeMapsPositions.Find(elem => elem.id == pMapId);

            return objMapPosition;
        }

        public string getLibelleIndiceFromPoiId(uint idPOI)
        {
            PointOfInterestLabel objIndice = gListeLabelPOI.Find(indice => indice.id == idPOI);

            return objIndice.label;
        }

        public bool isPhorreurOnMap(uint idPhorreur, GameRolePlayActorInformations[] listeActorsOnMap) // Retourne true si le phorreur recherché est présent sur la map
        {
            foreach (GameRolePlayActorInformations objActor in listeActorsOnMap) { 
                if (objActor is GameRolePlayTreasureHintInformations)
                {
                    GameRolePlayTreasureHintInformations objPhorreur = (GameRolePlayTreasureHintInformations)objActor;

                    if (objPhorreur.npcId == idPhorreur)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Evenement de changement de map
        public void eventMapChange(MapComplementaryInformationsDataMessage pObjCurrentMap)
        {
            try
            {
                if(gIsActive)
                {
                    gCurrentPlayerPosition = getPosFromMapId(pObjCurrentMap.mapId);
                    
                    if (gChasseEnCours != null && gChasseEnCours.currentStartMap != null)
                    {
                        if (gChasseEnCours.currentStartMap.Value.id == gCurrentPlayerPosition.id)
                        {
                            WindowManager.MainWindow.Logger.Info("Position de départ de l'indice");
                            goToHint();
                        }
                        else if (gChasseEnCours != null && gChasseEnCours.typeIndice == typeIndiceEnum.PHORREUR && gChasseEnCours.idIndice != null)
                        {
                            if(isPhorreurOnMap(gChasseEnCours.idIndice.Value, pObjCurrentMap.actors) == true)
                            {
                                WindowManager.MainWindow.Logger.Info("Phorreur trouvé");
                                InteractionsUI.SimpleClickToPoint(gUserSettings.Value.pointMilieu); // On annule déplacement
                                clickDrapeau(gChasseEnCours.nbCurrentFlag);
                            }
                        } else if (gChasseEnCours.positionIndice != null)
                        {
                            // Si on est arrivé a la position de l'indice
                            if (Int32.Parse(gCurrentPlayerPosition.posX) == gChasseEnCours.positionIndice.Value.x && Int32.Parse(gCurrentPlayerPosition.posY) == gChasseEnCours.positionIndice.Value.y)
                            {
                                clickDrapeau(gChasseEnCours.nbCurrentFlag);
                            }
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                WindowManager.MainWindow.Logger.Error("eventMapChange: " + ex.Message);
            }
        }

        // Evenement de reception d'une tramme de chasse 
        public void eventChasse(TreasureHuntMessage pEventChasse)
        {
            gChasseEnCours = null;

            try {
                if (gIsActive)
                {
                    // Si chasse non terminée
                    if (pEventChasse.totalStepCount > 0)
                    {
                        int nbCurrentFlag = pEventChasse.flags.Count();

                        // Si etape non terminée
                        if (nbCurrentFlag < pEventChasse.knownStepsList.Count())
                        {
                            TreasureHuntStep currentStep = pEventChasse.knownStepsList[nbCurrentFlag];

                            gChasseEnCours = new ChasseDetail();

                            gChasseEnCours.nbCurrentFlag = nbCurrentFlag;

                            if (currentStep.TypeId == TreasureHuntStepFollowDirectionToHint.Id) // Cas phorreurs
                            {
                                TreasureHuntStepFollowDirectionToHint directionToHint = (TreasureHuntStepFollowDirectionToHint)currentStep;

                                gChasseEnCours.typeIndice = typeIndiceEnum.PHORREUR;
                                gChasseEnCours.idIndice = directionToHint.npcId;
                                gChasseEnCours.direction = directionToHint.direction.ToString();
                            }
                            else if (currentStep.TypeId == TreasureHuntStepFollowDirectionToPOI.Id)
                            {
                                TreasureHuntStepFollowDirectionToPOI directionToPOI = (TreasureHuntStepFollowDirectionToPOI)currentStep;

                                gChasseEnCours.typeIndice = typeIndiceEnum.INDICE;
                                gChasseEnCours.idIndice = directionToPOI.poiLabelId;
                                gChasseEnCours.direction = directionToPOI.direction.ToString();
                            }

                            if (pEventChasse.flags.Count() > 0) // Si des flags on déjà été posés on récupère la derniere pos
                            {
                                gChasseEnCours.currentStartMap = getPosFromMapId(pEventChasse.flags.Last().mapId);
                            }
                            else // Position de start de la chasse
                            {
                                gChasseEnCours.currentStartMap = getPosFromMapId(pEventChasse.startMapId);
                            }

                            // WindowManager.MainWindow.Logger.Info("TreasureHuntMessage, map X: " + gChasseEnCours.currentStartMap.Value.posX + ", map Y: " + gChasseEnCours.currentStartMap.Value.posY + ", flags posés: " + nbCurrentFlag + ", Indice ID: " + gChasseEnCours.idIndice + ", direction: " + gChasseEnCours.direction);
                            // Si le joueur est sur la case de départ de l'indice on le déplace au nouvel indice
                            if (gCurrentPlayerPosition.id == gChasseEnCours.currentStartMap.Value.id)
                            {
                                goToHint();
                            }
                        }
                        else
                        {
                            WindowManager.MainWindow.Logger.Info("Etape terminée");
                            clickLoupe(nbCurrentFlag);
                        }
                    } else
                    {
                        WindowManager.MainWindow.Logger.Info("Chasse terminée");
                    }                    
                }
            } 
            catch (Exception ex)
            {
                WindowManager.MainWindow.Logger.Error("eventChasse: " + ex.Message);
            }
        }

        public void goToHint()
        {
            if (gChasseEnCours != null)
            {
                if (gChasseEnCours.typeIndice == typeIndiceEnum.INDICE)
                {

                    string libelleIndice = getLibelleIndiceFromPoiId(gChasseEnCours.idIndice.Value);
                    int hintFinderIndiceId = gObjHintFinder.mapLabelToClueId(libelleIndice);

                    string startPosX = gChasseEnCours.currentStartMap.Value.posX;
                    string startPosY = gChasseEnCours.currentStartMap.Value.posY;

                    if (String.IsNullOrWhiteSpace(startPosX) || String.IsNullOrWhiteSpace(startPosY))
                    {
                        WindowManager.MainWindow.Logger.Error("Erreur: Position inconnue");
                    }

                    hintFinder.Directions objDirection;

                    switch (gChasseEnCours.direction)
                    {
                        case "0":
                            objDirection = hintFinder.Directions.Droite;
                            break;

                        case "2":
                            objDirection = hintFinder.Directions.Bas;
                            break;

                        case "4":
                            objDirection = hintFinder.Directions.Gauche;
                            break;

                        case "6":
                            objDirection = hintFinder.Directions.Haut;
                            break;
                        default:
                            WindowManager.MainWindow.Logger.Error("Erreur: Direction inconnue");
                            return;
                    }

                    hintFinder.HintMap objPosIndice = gObjHintFinder.searchFromId(hintFinderIndiceId, int.Parse(startPosX), int.Parse(startPosY), objDirection); // Récuperation de la position de l'indice

                    gChasseEnCours.positionIndice = objPosIndice;

                    InteractionsUI.doTravelToPosition(objPosIndice.x, objPosIndice.y);
                }
                else if (gChasseEnCours.typeIndice == typeIndiceEnum.PHORREUR)
                {
                    // On travel de 10 cases, quand le phorreur sera trouvé sur la map l'event sera annulé
                    int posX;
                    int posY;

                    switch (gChasseEnCours.direction)
                    {
                        case "0": // Droite
                            posY = Int32.Parse(gChasseEnCours.currentStartMap.Value.posY);
                            posX = Int32.Parse(gChasseEnCours.currentStartMap.Value.posX) + 10;
                            break;

                        case "2": // Bas
                            posY = Int32.Parse(gChasseEnCours.currentStartMap.Value.posY + 10);
                            posX = Int32.Parse(gChasseEnCours.currentStartMap.Value.posX);
                            break;

                        case "4": // Gauche
                            posY = Int32.Parse(gChasseEnCours.currentStartMap.Value.posY);
                            posX = Int32.Parse(gChasseEnCours.currentStartMap.Value.posX) - 10;
                            break;

                        case "6": // Haut
                            posY = Int32.Parse(gChasseEnCours.currentStartMap.Value.posY) - 10;
                            posX = Int32.Parse(gChasseEnCours.currentStartMap.Value.posX);
                            break;
                        default:
                            WindowManager.MainWindow.Logger.Error("Erreur: Direction inconnue");
                            return;
                    }

                    InteractionsUI.doTravelToPosition(posX, posY);
                } 
                else
                {
                    WindowManager.MainWindow.Logger.Error("Erreur: Type d'indice inconnu");
                }
            } else
            {
                WindowManager.MainWindow.Logger.Error("Erreur: Chasse en cours inconnue");
            }
        }

        /// <summary>
        /// Clic sur un drapeau
        /// </summary>
        /// <param name="nbDrapeau">x eme drapeau a cliquer</param>
        /// <param name="offSet">Décalage en px entre chaque drapeau</param>
        public void clickDrapeau(int nbDrapeau, int offSet = 29)
        {
            int posY = gUserSettings.Value.drapeau1.Y + (nbDrapeau * offSet);
            Point pointToClick = new Point(gUserSettings.Value.drapeau1.X, posY);

            InteractionsUI.SimpleClickToPoint(pointToClick);
        }

        public void clickLoupe(int nbDrapeau, int offSet = 29)
        {
            int posYDernierDrapeau = gUserSettings.Value.drapeau1.Y + ((nbDrapeau - 1) * offSet);

            int posYLoupe = posYDernierDrapeau + 36;
            int posXLoupe = gUserSettings.Value.drapeau1.X - 15;

            Point pointToClick = new Point(posXLoupe, posYLoupe);

            Thread.Sleep(250);
            InteractionsUI.SimpleClickToPoint(pointToClick);
        }
    }
}
