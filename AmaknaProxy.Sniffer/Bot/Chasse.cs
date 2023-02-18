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
        public bool isActive = true; // TODO -> Gérer le booleen via une checkbox
        public double currentStartMapId { get; set; }
        private List<MapPositions> gListeMapsPositions { get; set; } // correspondances mapId -> Coordonées X/Y

        #region Structures
        public struct MapPositions
        {
            public double id;
            public string posX;
            public string posY;
        }
        #endregion

        // Constructeur
        public Chasse()
        {
            // ** Chargement des fichiers JSON **
            // Chargement des correspondances mapId -> Coordonées X/Y
            WindowManager.MainWindow.Logger.Info("Chargement des correspondances mapId -> Coordonées X/Y");

            using (StreamReader r = new StreamReader("Json/MapPositions.json"))
            {
                string json = r.ReadToEnd();
                gListeMapsPositions = JsonConvert.DeserializeObject<List<MapPositions>>(json);//Contient toutes les maps en fonction de l'id
            }

            WindowManager.MainWindow.Logger.Info(gListeMapsPositions.Count() + " maps trouvées");
        }

        public MapPositions getPosFromMapId(double pMapId)
        {
            MapPositions objMapPosition = gListeMapsPositions.Find(elem => elem.id == pMapId);

            return objMapPosition;
        }

        public void eventMapChange(MapComplementaryInformationsDataMessage pObjCurrentMap)
        {
            try
            {
                if(isActive)
                {
                    MapPositions currentPosXY = getPosFromMapId(pObjCurrentMap.mapId);
                    WindowManager.MainWindow.Logger.Info("Changement de map -> id: " + pObjCurrentMap.mapId + ", X: " + currentPosXY.posX + ", Y:" + currentPosXY.posY);
                }

            } 
            catch (Exception ex)
            {
                WindowManager.MainWindow.Logger.Error("eventMapChange: " + ex.Message);
            }
        }

        public void eventChasse(TreasureHuntMessage pEventChasse)
        {
            try {
                if (isActive)
                {
                    if (pEventChasse.totalStepCount > 0)
                    {
                        int nbCurrentFlag = pEventChasse.flags.Count();

                        if (nbCurrentFlag < pEventChasse.knownStepsList.Count())
                        {
                            TreasureHuntStep currentStep = pEventChasse.knownStepsList[nbCurrentFlag];

                            string labelId = "";
                            string direction = "";

                            if (currentStep.TypeId == TreasureHuntStepFollowDirectionToHint.Id) // Cas phorreurs
                            {
                                TreasureHuntStepFollowDirectionToHint directionToHint = (TreasureHuntStepFollowDirectionToHint)currentStep;
                                labelId = directionToHint.npcId.ToString() + " (Hint)";
                                direction = directionToHint.direction.ToString();

                            }
                            else if (currentStep.TypeId == TreasureHuntStepFollowDirectionToPOI.Id)
                            {
                                TreasureHuntStepFollowDirectionToPOI directionToPOI = (TreasureHuntStepFollowDirectionToPOI)currentStep;
                                labelId = directionToPOI.poiLabelId.ToString() + " (POI)";
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
