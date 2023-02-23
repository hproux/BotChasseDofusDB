namespace AmaknaProxy.Sniffer.View
{
    partial class Parametrage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametrage));
            this.input_directionHaut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_directionDroite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_directionBas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_directionGauche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.input_premierDrapeau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_directionHaut
            // 
            this.input_directionHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_directionHaut.Location = new System.Drawing.Point(339, 87);
            this.input_directionHaut.Name = "input_directionHaut";
            this.input_directionHaut.ReadOnly = true;
            this.input_directionHaut.Size = new System.Drawing.Size(101, 29);
            this.input_directionHaut.TabIndex = 0;
            this.input_directionHaut.Text = "Non défini";
            this.input_directionHaut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_directionHaut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_directionHaut_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliquez sur chaque case pour définir les zones de clic";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion des déplacements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Haut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Droite";
            // 
            // input_directionDroite
            // 
            this.input_directionDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_directionDroite.Location = new System.Drawing.Point(465, 136);
            this.input_directionDroite.Name = "input_directionDroite";
            this.input_directionDroite.ReadOnly = true;
            this.input_directionDroite.Size = new System.Drawing.Size(101, 29);
            this.input_directionDroite.TabIndex = 4;
            this.input_directionDroite.Text = "Non défini";
            this.input_directionDroite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_directionDroite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_directionDroite_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bas";
            // 
            // input_directionBas
            // 
            this.input_directionBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_directionBas.Location = new System.Drawing.Point(339, 196);
            this.input_directionBas.Name = "input_directionBas";
            this.input_directionBas.ReadOnly = true;
            this.input_directionBas.Size = new System.Drawing.Size(101, 29);
            this.input_directionBas.TabIndex = 6;
            this.input_directionBas.Text = "Non défini";
            this.input_directionBas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_directionBas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_directionBas_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gauche";
            // 
            // input_directionGauche
            // 
            this.input_directionGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_directionGauche.Location = new System.Drawing.Point(220, 136);
            this.input_directionGauche.Name = "input_directionGauche";
            this.input_directionGauche.ReadOnly = true;
            this.input_directionGauche.Size = new System.Drawing.Size(101, 29);
            this.input_directionGauche.TabIndex = 8;
            this.input_directionGauche.Text = "Non défini";
            this.input_directionGauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_directionGauche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_directionGauche_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gestion des drapeaux";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Premier drapeau";
            // 
            // input_premierDrapeau
            // 
            this.input_premierDrapeau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_premierDrapeau.Location = new System.Drawing.Point(45, 278);
            this.input_premierDrapeau.Name = "input_premierDrapeau";
            this.input_premierDrapeau.ReadOnly = true;
            this.input_premierDrapeau.Size = new System.Drawing.Size(101, 29);
            this.input_premierDrapeau.TabIndex = 11;
            this.input_premierDrapeau.Text = "Non défini";
            this.input_premierDrapeau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_premierDrapeau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_premierDrapeau_KeyUp);
            // 
            // Parametrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_premierDrapeau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_directionGauche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_directionBas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_directionDroite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_directionHaut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parametrage";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Paramètres";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_directionHaut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_directionDroite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_directionBas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_directionGauche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox input_premierDrapeau;
    }
}