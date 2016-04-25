namespace SimpleTextEditor
{
    partial class FrmSimpleTextEditor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.LightCoral;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuMain_MouseDown);
            this.menuMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMain_MouseMove);
            this.menuMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuMain_MouseUp);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOuvrir,
            this.menuSave,
            this.menuQuitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuOuvrir
            // 
            this.menuOuvrir.Name = "menuOuvrir";
            this.menuOuvrir.Size = new System.Drawing.Size(198, 26);
            this.menuOuvrir.Text = "Ouvrir";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(198, 26);
            this.menuSave.Text = "Enrengistrer Sous";
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(198, 26);
            this.menuQuitter.Text = "Quitter";
            this.menuQuitter.Click += new System.EventHandler(this.clickOnExit);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtbAffiche.Location = new System.Drawing.Point(0, 31);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAffiche.Size = new System.Drawing.Size(800, 600);
            this.rtbAffiche.TabIndex = 1;
            this.rtbAffiche.Text = "";
            // 
            // FrmSimpleTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmSimpleTextEditor";
            this.Text = "Simple Text Editor";
            this.Load += new System.EventHandler(this.FrmSimpleTextEditor_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.ToolStripMenuItem menuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuQuitter;
    }
}

