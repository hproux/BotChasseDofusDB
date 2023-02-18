using AmaknaProxy.API.Managers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AmaknaProxy.Sniffer.Bot
{
    public class Chasse
    {
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
    }
}
