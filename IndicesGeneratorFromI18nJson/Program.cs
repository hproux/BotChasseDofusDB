using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IndicesGeneratorFromI18nJson
{
    internal class Program
    {
        private struct sourceI18nJson {
            public Dictionary<uint, string> texts;
        }

        private struct sourcePOI
        {
            public uint id; // id du poi dans la tramme 
            public uint nameId; // id de la traduction dans le fichier i18n
        }

        private struct outputJson
        {
            public uint id; // Identifiant du POI
            public string label; // libellé du poi
        }

        static void Main(string[] args)
        {
            List<outputJson> objOutput = new List<outputJson>();
            List<sourcePOI> listePOI = new List<sourcePOI>();
            sourceI18nJson dictLibelles = new sourceI18nJson();


            // Chargement de la liste des POI
            using (StreamReader r = new StreamReader("PointOfInterest.json"))
            {
                string json = r.ReadToEnd();
                listePOI = JsonConvert.DeserializeObject<List<sourcePOI>>(json);//Contient la liste de tous les POI dans le fichier PointOfInterest.json
            }

            // Chargement de toutes les traductions
            using (StreamReader r = new StreamReader("i18n_fr.json"))
            {
                string json = r.ReadToEnd();
                dictLibelles = JsonConvert.DeserializeObject<sourceI18nJson>(json);//Contient la listede toutes les traductions
            }

            // Chargement de tous les libellé des POI
            foreach (var objPOI in listePOI)
            {
                if (dictLibelles.texts.ContainsKey(objPOI.nameId))
                {
                    string libellePOI = dictLibelles.texts[objPOI.nameId];

                    objOutput.Add(new outputJson()
                    {
                        id = objPOI.id,
                        label = libellePOI
                    });
                }

                
            }

            // Ecriture du fichier de sortie filtré
            string jsonOut = JsonConvert.SerializeObject(objOutput);

            //write string to file
            System.IO.Directory.CreateDirectory("output");
            System.IO.File.WriteAllText("output/idToLibellePOI.json", jsonOut);
        }
    }
}
