namespace AmaknaProxy.Engine.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DockPanel_Main = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Proxy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DebugMod = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundWorker_Load = new System.ComponentModel.BackgroundWorker();
            this.NotifyIcon_Proxy = new System.Windows.Forms.NotifyIcon(this.components);
            this.paramètrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // DockPanel_Main
            // 
            this.DockPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel_Main.DockBackColor = System.Drawing.SystemColors.Control;
            this.DockPanel_Main.Location = new System.Drawing.Point(0, 24);
            this.DockPanel_Main.Name = "DockPanel_Main";
            this.DockPanel_Main.Size = new System.Drawing.Size(1075, 528);
            this.DockPanel_Main.TabIndex = 1;
            this.DockPanel_Main.ActiveContentChanged += new System.EventHandler(this.DockPanel_Main_ActiveContentChanged);
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.BackColor = System.Drawing.Color.White;
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Proxy,
            this.ToolStripMenuItem_Game,
            this.ToolStripMenuItem_DebugMod,
            this.paramètrageToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(1075, 24);
            this.MenuStrip_Main.TabIndex = 4;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Proxy
            // 
            this.ToolStripMenuItem_Proxy.Name = "ToolStripMenuItem_Proxy";
            this.ToolStripMenuItem_Proxy.Size = new System.Drawing.Size(130, 20);
            this.ToolStripMenuItem_Proxy.Text = "Proxy : Chargement..";
            this.ToolStripMenuItem_Proxy.Visible = false;
            this.ToolStripMenuItem_Proxy.Click += new System.EventHandler(this.ToolStripMenuItem_Proxy_Click);
            // 
            // ToolStripMenuItem_Game
            // 
            this.ToolStripMenuItem_Game.Name = "ToolStripMenuItem_Game";
            this.ToolStripMenuItem_Game.Size = new System.Drawing.Size(129, 20);
            this.ToolStripMenuItem_Game.Text = "Démarrer le launcher";
            this.ToolStripMenuItem_Game.Click += new System.EventHandler(this.ToolStripMenuItem_Game_Click);
            // 
            // ToolStripMenuItem_DebugMod
            // 
            this.ToolStripMenuItem_DebugMod.Name = "ToolStripMenuItem_DebugMod";
            this.ToolStripMenuItem_DebugMod.Size = new System.Drawing.Size(114, 20);
            this.ToolStripMenuItem_DebugMod.Text = "Debug: Désactiver";
            this.ToolStripMenuItem_DebugMod.Visible = false;
            this.ToolStripMenuItem_DebugMod.Click += new System.EventHandler(this.ToolStripMenuItem_DebugMod_Click);
            // 
            // BackgroundWorker_Load
            // 
            this.BackgroundWorker_Load.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_Load_DoWork);
            // 
            // NotifyIcon_Proxy
            // 
            this.NotifyIcon_Proxy.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_Proxy.Icon")));
            this.NotifyIcon_Proxy.Text = "AmaknaProxy";
            this.NotifyIcon_Proxy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_Proxy_MouseDoubleClick);
            // 
            // paramètrageToolStripMenuItem
            // 
            this.paramètrageToolStripMenuItem.Name = "paramètrageToolStripMenuItem";
            this.paramètrageToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.paramètrageToolStripMenuItem.Text = "Paramétrage";
            this.paramètrageToolStripMenuItem.Click += new System.EventHandler(this.paramètrageToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 552);
            this.Controls.Add(this.DockPanel_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "MainForm";
            this.Text = "Dofus Chasses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Game;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Proxy;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_Load;
        public WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel_Main;
        public System.Windows.Forms.NotifyIcon NotifyIcon_Proxy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DebugMod;
        private System.Windows.Forms.ToolStripMenuItem paramètrageToolStripMenuItem;
    }
}