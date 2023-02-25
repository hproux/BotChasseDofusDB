using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaProxy.Sniffer.Bot
{
    public class hintFinder
    {
        public enum Directions
        {
            Droite = 0,
            Bas = 2,
            Gauche = 4,
            Haut = 6,
        }

        private List<MapPositions> IdandLabelList { get; set; }
        private List<HintMap> HintMapList { get; set; }
        public struct MapPositions
        {
            public int clueid;
            public string hintfr;
        }

        public struct HintMap
        {
            public int x;
            public int y;
            public List<string> clues;
        }

        public hintFinder()
        {
            using (StreamReader r = new StreamReader("Json/listeHint.json"))
            {
                string json = r.ReadToEnd();
                HintMapList = JsonConvert.DeserializeObject<List<HintMap>>(json);//Contient toutes les maps en fonction de l'id
            }

            using (StreamReader r = new StreamReader("Json/listeCorrespondances.json"))
            {
                string json = r.ReadToEnd();
                IdandLabelList = JsonConvert.DeserializeObject<List<MapPositions>>(json);//Contient toutes les maps en fonction de l'id
            }

        }

        public int mapLabelToClueId(string label)
        {
            //
            MapPositions currentHint = IdandLabelList.Find(mapping => String.Compare(label, mapping.hintfr, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0);
            return currentHint.clueid;
        }

        public HintMap? searchFromId(int hintId, int Xpos, int Ypos, Directions direction)
        {
            List<HintMap> maps = HintMapList.FindAll(map => {
                switch (direction)
                {
                    case Directions.Droite:
                        if (map.y == Ypos && map.x > Xpos && map.x <= Xpos + 10)
                        {
                            return true;
                        }
                        break;
                    case Directions.Bas:
                        if (map.x == Xpos && map.y > Ypos && map.y <= Ypos + 10)
                        {
                            return true;
                        }
                        break;
                    case Directions.Gauche:
                        if (map.y == Ypos && map.x < Xpos && map.x >= Xpos - 10)
                        {
                            return true;
                        }
                        break;

                    case Directions.Haut:
                        if (map.x == Xpos && map.y < Ypos && map.y >= Ypos - 10)
                        {
                            return true;
                        }
                        break;
                }
                return false;
            });

            maps = maps.FindAll(map => map.clues.Contains(hintId.ToString()));

            HintMap? hintFound = null;

            switch (direction)
            {
                case Directions.Droite:
                    hintFound = maps.OrderBy(map => map.x).FirstOrDefault();
                    break;
                case Directions.Bas:
                    hintFound = maps.OrderBy(map => map.y).FirstOrDefault();
                    break;
                case Directions.Gauche:
                    hintFound = maps.OrderBy(map => map.x).LastOrDefault();
                    break;

                case Directions.Haut:
                    hintFound = maps.OrderBy(map => map.y).LastOrDefault();
                    break;
            }

            return hintFound;

        }
    }
}
