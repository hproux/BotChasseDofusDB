using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaProxy.Sniffer
{
    public static class Constants
    {
        // TODO Erreur dans les ip ?? 34.249.202.222 semble OK
        public static string[] LoginAddresses = { "54.76.16.121", "34.249.202.222" }; //,  "34.252.21.81", "52.17.231.202", "63.34.214.78"
        // "54.76.16.121", "34.249.202.222"
        public static int[] LoginPorts = { 5555, 443 };

    }
}
