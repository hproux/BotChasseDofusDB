using AmaknaProxy.API.Managers;
using AmaknaProxy.Sniffer.Bot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmaknaProxy.Sniffer.View
{
    public partial class Parametrage : Form
    {
        public Parametrage()
        {
            InitializeComponent();

            InteractionsUI.userSettings? objSettings =  InteractionsUI.getUserCurseursRegistre();

            if (objSettings != null)
            {
                input_premierDrapeau.Text = "OK";
                input_pointMilieu.Text = "OK";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_premierDrapeau_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptDrapeau);

            input_premierDrapeau.Text = "OK";
        }

        private void input_milieuEcran_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptMilieu);

            input_pointMilieu.Text = "OK";
        }
    }
}
