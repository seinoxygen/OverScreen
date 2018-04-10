﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverScreen
{
    public partial class frmMain : Form
    {
        public Stream image;

        private OverScreen overScreen;

        private Form frmImage;

        public frmMain()
        {
            InitializeComponent();

            overScreen = new OverScreen();
        }        

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "Imagen|*.png; *.jpg; *.bmp";
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                image = fileBrowser.OpenFile();
                txtFile.Text = fileBrowser.FileName;

                Image bitmap = Bitmap.FromStream(image);
                
                frmImage = new frmImage();
                frmImage.BackgroundImage = Bitmap.FromStream(image);
                frmImage.Width = bitmap.Width;
                frmImage.Height = bitmap.Height;

                frmImage.Show();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            frmImage.Opacity = trbOpacity.Value * 000.01d;
        }
    }
}