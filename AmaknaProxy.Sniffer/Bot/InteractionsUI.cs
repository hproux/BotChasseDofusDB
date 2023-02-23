using AmaknaProxy.API.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmaknaProxy.Sniffer.Bot
{
    // Gestion des événements liés à l'UI
    public class InteractionsUI
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public const string ptHaut = "ptHaut";
        public const string ptDroite = "ptDroite";
        public const string ptBas = "ptBas";
        public const string ptGauche = "ptGauche";
        public const string ptDrapeau = "ptDrapeau";

        public struct userSettings
        {
            public Point deplacementHaut;
            public Point deplacementDroite;
            public Point deplacementBas;
            public Point deplacementGauche;
            public Point drapeau1;
        }

        public static Point GetCursorPos()
        {
            Point pt = new Point();
            pt.X = Cursor.Position.X;
            pt.Y = Cursor.Position.Y;
            return pt;
        }

        public static void SetCursorPos(int X, int Y)
        {
            Point pt = new Point();
            pt.X = X;
            pt.Y = Y;
            Cursor.Position = pt;
        }

        public static void LeftClick()
        {
            //perform click            
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            WindowManager.MainWindow.Logger.Debug("Clic gauche");
        }

        public static void savePointCurseurRegistre(Point pt, string idCurseur)
        {
            Microsoft.Win32.RegistryKey keyRegister = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("BotChasse", true);

            if (keyRegister == null)
            {
                keyRegister = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("BotChasse");
            }

            keyRegister.SetValue(idCurseur + "X", pt.X);
            keyRegister.SetValue(idCurseur + "Y", pt.Y);

            WindowManager.MainWindow.Logger.Info("Point " + idCurseur + " défini en X:" + pt.X + ", Y: " + pt.Y);
        }
    }
}
