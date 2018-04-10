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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.trbOpacity = new System.Windows.Forms.TrackBar();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpOpacity = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).BeginInit();
            this.grpImage.SuspendLayout();
            this.grpOpacity.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.grpImage.Location = new System.Drawing.Point(12, 12);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(260, 55);
            this.grpImage.TabIndex = 3;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Imagen";
            // 
            // grpOpacity
            // 
            this.grpOpacity.Controls.Add(this.trbOpacity);
            this.grpOpacity.Location = new System.Drawing.Point(12, 73);
            this.grpOpacity.Name = "grpOpacity";
            this.grpOpacity.Size = new System.Drawing.Size(260, 66);
            this.grpOpacity.TabIndex = 4;
            this.grpOpacity.TabStop = false;
            this.grpOpacity.Text = "Opacidad";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.grpOpacity);
            this.Controls.Add(this.grpImage);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).EndInit();
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            this.grpOpacity.ResumeLayout(false);
            this.grpOpacity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TrackBar trbOpacity;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.GroupBox grpOpacity;
    }
}

