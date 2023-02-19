using AmaknaProxy.API.Managers;
using AmaknaProxy.API.Protocol.Messages;
using AmaknaProxy.API.Protocol.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AmaknaProxy.Sniffer.Bot
{
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

        public bool isActive { get; set; }
        public double currentStartMapId { get; set; }
        public MapPositions startMap { get; set; } // Contient la map de départ de l'indice courant
        public List<MapPositions> gListeMapsPositions { get; set; } // correspondances mapId -> Coordonées X/Y

        public List<PointOfInterestLabel> gListeLabelPOI { get; set; } // Contient les libellé de chaque POI

        public uint? idPhorreurToFind { get; set; } // Si renseigné, on recherche actuellement un phorreur

        // Constructeur
        public Chasse()
        {
            isActive = true; // TODO -> Gérer le booleen via une checkbox
            idPhorreurToFind = null;

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
                if(isActive)
                {
                    MapPositions currentPosXY = getPosFromMapId(pObjCurrentMap.mapId);

                    WindowManager.MainWindow.Logger.Info("Changement de map -> id: " + pObjCurrentMap.mapId + ", X: " + currentPosXY.posX + ", Y:" + currentPosXY.posY);
                    
                    if (startMap.id != 0)
                    {
                        if (startMap.id == currentPosXY.id)
                        {
                            WindowManager.MainWindow.Logger.Info("Position de départ de l'indice");
                            // TODO -> Demarrage de la chasse
                        }

                        if (idPhorreurToFind != null)
                        {
                            if(isPhorreurOnMap(idPhorreurToFind.Value, pObjCurrentMap.actors) == true)
                            {
                                WindowManager.MainWindow.Logger.Info("Phorreur trouvé");
                                // TODO Cliquer sur le jalon
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
            startMap = new MapPositions();
            idPhorreurToFind = null;

            try {
                if (isActive)
                {
                    // Si chasse non terminée
                    if (pEventChasse.totalStepCount > 0)
                    {
                        int nbCurrentFlag = pEventChasse.flags.Count();

                        // Si etape non terminée
                        if (nbCurrentFlag < pEventChasse.knownStepsList.Count())
                        {
                            TreasureHuntStep currentStep = pEventChasse.knownStepsList[nbCurrentFlag];

                            string labelId = "";
                            string direction = "";

                            if (currentStep.TypeId == TreasureHuntStepFollowDirectionToHint.Id) // Cas phorreurs
                            {
                                TreasureHuntStepFollowDirectionToHint directionToHint = (TreasureHuntStepFollowDirectionToHint)currentStep;
                                labelId = directionToHint.npcId.ToString() + " (Hint)";
                                idPhorreurToFind = directionToHint.npcId; // On indique qu'on recherche un phorreur
                                direction = directionToHint.direction.ToString();

                            }
                            else if (currentStep.TypeId == TreasureHuntStepFollowDirectionToPOI.Id)
                            {
                                TreasureHuntStepFollowDirectionToPOI directionToPOI = (TreasureHuntStepFollowDirectionToPOI)currentStep;
                                labelId = directionToPOI.poiLabelId.ToString() + " (POI: " + getLibelleIndiceFromPoiId(directionToPOI.poiLabelId) + ")";
                                direction = directionToPOI.direction.ToString();
                            }


                            MapPositions objPos;

                            if (pEventChasse.flags.Count() > 0) // Si des flags on déjà été posés on récupère la derniere pos
                            {
                                objPos = getPosFromMapId(pEventChasse.flags.Last().mapId);
                            }
                            else // Position de start de la chasse
                            {
                                objPos = getPosFromMapId(pEventChasse.startMapId);
                            }

                            startMap = objPos;

                            WindowManager.MainWindow.Logger.Info("TreasureHuntMessage, map X: " + objPos.posX + ", map Y: " + objPos.posY + ", flags posés: " + nbCurrentFlag + ", Indice ID: " + labelId + ", direction: " + direction);

                        }
                        else
                        {
                            WindowManager.MainWindow.Logger.Info("Etape terminée");
                            // TODO -> Validation de l'etape
                            // detecter si erreur (si oui arreter le mode auto)
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
    }
}
