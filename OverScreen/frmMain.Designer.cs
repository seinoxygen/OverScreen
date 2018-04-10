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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.mniTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniScreenCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOpenCaptureFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            // opnFileDialog
            // 
            resources.ApplyResources(this.opnFileDialog, "opnFileDialog");
            // 
            // btnOpenImage
            // 
            resources.ApplyResources(this.btnOpenImage, "btnOpenImage");
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // trbOpacity
            // 
            resources.ApplyResources(this.trbOpacity, "trbOpacity");
            this.trbOpacity.LargeChange = 10;
            this.trbOpacity.Maximum = 100;
            this.trbOpacity.Name = "trbOpacity";
            this.trbOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbOpacity.Value = 75;
            this.trbOpacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtFile
            // 
            resources.ApplyResources(this.txtFile, "txtFile");
            this.txtFile.Name = "txtFile";
            // 
            // grpImage
            // 
            resources.ApplyResources(this.grpImage, "grpImage");
            this.grpImage.Controls.Add(this.btnOpenImage);
            this.grpImage.Controls.Add(this.txtFile);
            this.grpImage.Name = "grpImage";
            this.grpImage.TabStop = false;
            // 
            // grpOpacity
            // 
            resources.ApplyResources(this.grpOpacity, "grpOpacity");
            this.grpOpacity.Controls.Add(this.trbOpacity);
            this.grpOpacity.Name = "grpOpacity";
            this.grpOpacity.TabStop = false;
            // 
            // mnuMain
            // 
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniTools,
            this.mniHelp});
            this.mnuMain.Name = "mnuMain";
            // 
            // mniFile
            // 
            resources.ApplyResources(this.mniFile, "mniFile");
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpen,
            this.sepOne,
            this.mniClose});
            this.mniFile.Name = "mniFile";
            // 
            // mniOpen
            // 
            resources.ApplyResources(this.mniOpen, "mniOpen");
            this.mniOpen.Name = "mniOpen";
            this.mniOpen.Click += new System.EventHandler(this.mniOpen_Click);
            // 
            // sepOne
            // 
            resources.ApplyResources(this.sepOne, "sepOne");
            this.sepOne.Name = "sepOne";
            // 
            // mniClose
            // 
            resources.ApplyResources(this.mniClose, "mniClose");
            this.mniClose.Name = "mniClose";
            this.mniClose.Click += new System.EventHandler(this.mniClose_Click);
            // 
            // mniTools
            // 
            resources.ApplyResources(this.mniTools, "mniTools");
            this.mniTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniScreenCapture,
            this.mniOpenCaptureFolder});
            this.mniTools.Name = "mniTools";
            // 
            // mniScreenCapture
            // 
            resources.ApplyResources(this.mniScreenCapture, "mniScreenCapture");
            this.mniScreenCapture.Name = "mniScreenCapture";
            this.mniScreenCapture.Click += new System.EventHandler(this.mniScreenCapture_Click);
            // 
            // mniOpenCaptureFolder
            // 
            resources.ApplyResources(this.mniOpenCaptureFolder, "mniOpenCaptureFolder");
            this.mniOpenCaptureFolder.Name = "mniOpenCaptureFolder";
            this.mniOpenCaptureFolder.Click += new System.EventHandler(this.mniOpenCaptureFolder_Click);
            // 
            // mniHelp
            // 
            resources.ApplyResources(this.mniHelp, "mniHelp");
            this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUpdates,
            this.mniAbout});
            this.mniHelp.Name = "mniHelp";
            // 
            // mniUpdates
            // 
            resources.ApplyResources(this.mniUpdates, "mniUpdates");
            this.mniUpdates.Name = "mniUpdates";
            this.mniUpdates.Click += new System.EventHandler(this.mniUpdates_Click);
            // 
            // mniAbout
            // 
            resources.ApplyResources(this.mniAbout, "mniAbout");
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Click += new System.EventHandler(this.mniAbout_Click);
            // 
            // grpRotation
            // 
            resources.ApplyResources(this.grpRotation, "grpRotation");
            this.grpRotation.Controls.Add(this.trkRotation);
            this.grpRotation.Name = "grpRotation";
            this.grpRotation.TabStop = false;
            // 
            // trkRotation
            // 
            resources.ApplyResources(this.trkRotation, "trkRotation");
            this.trkRotation.Maximum = 36;
            this.trkRotation.Name = "trkRotation";
            this.trkRotation.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkRotation.Scroll += new System.EventHandler(this.trkRotation_Scroll);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpRotation);
            this.Controls.Add(this.grpOpacity);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
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
        private System.Windows.Forms.ToolStripMenuItem mniTools;
        private System.Windows.Forms.ToolStripMenuItem mniScreenCapture;
        private System.Windows.Forms.ToolStripMenuItem mniOpenCaptureFolder;
    }
}

