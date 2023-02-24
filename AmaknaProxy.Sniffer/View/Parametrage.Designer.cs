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
            this.input_pointMilieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.input_premierDrapeau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_pointMilieu
            // 
            this.input_pointMilieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_pointMilieu.Location = new System.Drawing.Point(81, 91);
            this.input_pointMilieu.Name = "input_pointMilieu";
            this.input_pointMilieu.ReadOnly = true;
            this.input_pointMilieu.Size = new System.Drawing.Size(101, 29);
            this.input_pointMilieu.TabIndex = 0;
            this.input_pointMilieu.Text = "Non défini";
            this.input_pointMilieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_pointMilieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_milieuEcran_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliquez sur chaque case pour définir les zones de clic";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Milieu écran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Premier drapeau";
            // 
            // input_premierDrapeau
            // 
            this.input_premierDrapeau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_premierDrapeau.Location = new System.Drawing.Point(326, 91);
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
            this.ClientSize = new System.Drawing.Size(504, 159);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_premierDrapeau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_pointMilieu);
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

        private System.Windows.Forms.TextBox input_pointMilieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox input_premierDrapeau;
    }
}