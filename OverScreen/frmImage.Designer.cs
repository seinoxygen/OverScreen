namespace OverScreen
{
    partial class frmImage
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
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxClose});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // ctxClose
            // 
            this.ctxClose.Name = "ctxClose";
            this.ctxClose.Size = new System.Drawing.Size(180, 22);
            this.ctxClose.Text = "Cerrar";
            this.ctxClose.Click += new System.EventHandler(this.ctxClose_Click);
            // 
            // frmImage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.ctxMenu;
            this.Name = "frmImage";
            this.Load += new System.EventHandler(this.frmImage_Load);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxClose;
    }
}