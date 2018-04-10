namespace OverScreen
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.opnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.trbOpacity = new System.Windows.Forms.TrackBar();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpOpacity = new System.Windows.Forms.GroupBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.sepOne = new System.Windows.Forms.ToolStripSeparator();
            this.mniClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRotation = new System.Windows.Forms.GroupBox();
            this.trkRotation = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).BeginInit();
            this.grpImage.SuspendLayout();
            this.grpOpacity.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.grpRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(179, 19);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Abrir";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // trbOpacity
            // 
            this.trbOpacity.LargeChange = 10;
            this.trbOpacity.Location = new System.Drawing.Point(6, 19);
            this.trbOpacity.Maximum = 100;
            this.trbOpacity.Name = "trbOpacity";
            this.trbOpacity.Size = new System.Drawing.Size(248, 45);
            this.trbOpacity.TabIndex = 1;
            this.trbOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbOpacity.Value = 75;
            this.trbOpacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(6, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(167, 20);
            this.txtFile.TabIndex = 2;
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.btnOpenImage);
            this.grpImage.Controls.Add(this.txtFile);
            this.grpImage.Location = new System.Drawing.Point(12, 27);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(260, 55);
            this.grpImage.TabIndex = 3;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Imagen";
            // 
            // grpOpacity
            // 
            this.grpOpacity.Controls.Add(this.trbOpacity);
            this.grpOpacity.Location = new System.Drawing.Point(12, 88);
            this.grpOpacity.Name = "grpOpacity";
            this.grpOpacity.Size = new System.Drawing.Size(260, 66);
            this.grpOpacity.TabIndex = 4;
            this.grpOpacity.TabStop = false;
            this.grpOpacity.Text = "Opacidad";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(284, 24);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpen,
            this.sepOne,
            this.mniClose});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(60, 20);
            this.mniFile.Text = "Archivo";
            // 
            // mniOpen
            // 
            this.mniOpen.Name = "mniOpen";
            this.mniOpen.Size = new System.Drawing.Size(180, 22);
            this.mniOpen.Text = "&Abrir";
            this.mniOpen.Click += new System.EventHandler(this.mniOpen_Click);
            // 
            // sepOne
            // 
            this.sepOne.Name = "sepOne";
            this.sepOne.Size = new System.Drawing.Size(177, 6);
            // 
            // mniClose
            // 
            this.mniClose.Name = "mniClose";
            this.mniClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mniClose.Size = new System.Drawing.Size(180, 22);
            this.mniClose.Text = "Cerrar";
            this.mniClose.Click += new System.EventHandler(this.mniClose_Click);
            // 
            // mniHelp
            // 
            this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUpdates,
            this.mniAbout});
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(53, 20);
            this.mniHelp.Text = "Ayuda";
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(194, 22);
            this.mniAbout.Text = "Acerca De OverScreen";
            this.mniAbout.Click += new System.EventHandler(this.mniAbout_Click);
            // 
            // mniUpdates
            // 
            this.mniUpdates.Name = "mniUpdates";
            this.mniUpdates.Size = new System.Drawing.Size(194, 22);
            this.mniUpdates.Text = "Buscar Actualizaciones";
            this.mniUpdates.Click += new System.EventHandler(this.mniUpdates_Click);
            // 
            // grpRotation
            // 
            this.grpRotation.Controls.Add(this.trkRotation);
            this.grpRotation.Location = new System.Drawing.Point(12, 160);
            this.grpRotation.Name = "grpRotation";
            this.grpRotation.Size = new System.Drawing.Size(260, 71);
            this.grpRotation.TabIndex = 6;
            this.grpRotation.TabStop = false;
            this.grpRotation.Text = "Rotación";
            // 
            // trkRotation
            // 
            this.trkRotation.Location = new System.Drawing.Point(3, 16);
            this.trkRotation.Maximum = 36;
            this.trkRotation.Name = "trkRotation";
            this.trkRotation.Size = new System.Drawing.Size(251, 45);
            this.trkRotation.TabIndex = 0;
            this.trkRotation.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.grpRotation);
            this.Controls.Add(this.grpOpacity);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).EndInit();
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            this.grpOpacity.ResumeLayout(false);
            this.grpOpacity.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpRotation.ResumeLayout(false);
            this.grpRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opnFileDialog;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TrackBar trbOpacity;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.GroupBox grpOpacity;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniOpen;
        private System.Windows.Forms.ToolStripSeparator sepOne;
        private System.Windows.Forms.ToolStripMenuItem mniClose;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
        private System.Windows.Forms.ToolStripMenuItem mniUpdates;
        private System.Windows.Forms.GroupBox grpRotation;
        private System.Windows.Forms.TrackBar trkRotation;
    }
}

