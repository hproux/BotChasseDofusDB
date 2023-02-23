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

            // TODO Dans la classe, ajouter une fonction qui récupère tous les points et modifier les libellés en fonction
            //InteractionsUI.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_directionHaut_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptHaut);

            input_directionHaut.Text = "OK";
        }

        private void input_directionGauche_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptGauche);

            input_directionGauche.Text = "OK";
        }

        private void input_directionBas_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptBas);

            input_directionBas.Text = "OK";
        }

        private void input_directionDroite_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptDroite);

            input_directionDroite.Text = "OK";
        }

        private void input_premierDrapeau_KeyUp(object sender, KeyEventArgs e)
        {
            Point pt = InteractionsUI.GetCursorPos();
            InteractionsUI.savePointCurseurRegistre(pt, InteractionsUI.ptDrapeau);

            input_directionDroite.Text = "OK";
        }
    }
}
