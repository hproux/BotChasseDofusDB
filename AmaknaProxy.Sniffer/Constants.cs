﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaProxy.Sniffer
{
    public static class Constants
    {
        public static string[] LoginAddresses = { "54.77.254.99", "34.249.202.222", "54.76.16.121" };

        public static int[] LoginPorts = { 5555, 443 };

        public enum MessageReceiverEnum
        {
            // Connexion
            SelectedServerDataMessage = 8715,
            SelectedServerDataExtendedMessage = 9230,
            IdentificationSuccessMessage = 3593,
            IdentificationSuccessWithLoginTokenMessage = 261,
            CharacterSelectedSuccessMessage = 3893,

            // Deplacements
            MapComplementaryInformationsDataMessage = 4524,

            // Chasse
            TreasureHuntMessage = 8209
        }
    }
}
