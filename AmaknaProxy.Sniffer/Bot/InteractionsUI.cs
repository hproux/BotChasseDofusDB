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

        public const string ptMilieu = "ptMilieu";
        public const string ptDrapeau = "ptDrapeau";

        public struct userSettings
        {
            public Point pointMilieu;
            public Point drapeau1;
        }

        public static Point GetCursorPos()
        {
            Point pt = new Point();
            pt.X = Cursor.Position.X;
            pt.Y = Cursor.Position.Y;
            return pt;
        }

        private static void SetCursorPos(int X, int Y)
        {
            Point pt = new Point();
            pt.X = X;
            pt.Y = Y;
            Cursor.Position = pt;
        }

        private static void LeftClick()
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

        public static userSettings? getUserCurseursRegistre()
        {
            userSettings? objUserSettings = null;

            Microsoft.Win32.RegistryKey keyRegister = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("BotChasse", true);

            if (keyRegister != null)
            {
                try
                {
                    objUserSettings = new userSettings() { 
                        pointMilieu = new Point(Int32.Parse(keyRegister.GetValue(ptMilieu + "X").ToString()), Int32.Parse(keyRegister.GetValue(ptMilieu + "Y").ToString())),
                        drapeau1 = new Point(Int32.Parse(keyRegister.GetValue(ptDrapeau + "X").ToString()), Int32.Parse(keyRegister.GetValue(ptDrapeau + "Y").ToString()))
                    };

                }
                catch (Exception ex)
                {
                    objUserSettings = null;
                    WindowManager.MainWindow.Logger.Error("Configuration incomplète, veuillez définir les points dans l'onglet configuration puis redémarrer votre jeu");
                }

            }

            return objUserSettings;
        }
        
        /// <summary>
        /// Effectue un clic à la position donnée
        /// </summary>
        /// <param name="idCurseur"></param>
        public static void SimpleClickToPoint(Point pointToClick)
        {
            Thread thread = new Thread(() => {
                Thread.Sleep(200);
                SetCursorPos(pointToClick.X, pointToClick.Y);
                LeftClick();
            });

            thread.Start();
        }

        public static void doTravelToPosition(int posX, int posY)
        {
            string travelCommand = "/travel " + posX + " " + posY;

            copyToClipboard(travelCommand);

            Thread thread = new Thread(() => {
                Thread.Sleep(500);
                SendKeys.SendWait("^{ENTER}"); //Control + Entree -> Entre en ecriture dans le chat
                Thread.Sleep(100);
                SendKeys.SendWait("^{v}"); //Control + V -> Copie le travel
                Thread.Sleep(100);
                SendKeys.SendWait("{ENTER}"); //Enter -> Envoi la commande travel
                Thread.Sleep(400);
                SendKeys.SendWait("{ENTER}"); //Enter -> Valide le travel
            });

            thread.Start();
        }

        public static void copyToClipboard(string command)
        {
            Thread thread = new Thread(() => Clipboard.SetText(command));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
