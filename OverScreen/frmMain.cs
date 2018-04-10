using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverScreen
{
    public partial class frmMain : Form
    {
        public Image image;

        private OverScreen overScreen;

        private Form frmImage;

        public frmMain()
        {
            InitializeComponent();

            overScreen = new OverScreen();
        }

        #region "TOP MENU"
        private void mniOpen_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void mniClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/seinoxygen/OverScreen");
        }

        private void mniUpdates_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/seinoxygen/OverScreen/releases");
        }
        #endregion

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            frmImage.Opacity = trbOpacity.Value * 000.01d;
        }      

        private void LoadFile()
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "Imagen|*.png; *.jpg; *.bmp";
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                Stream sImage = fileBrowser.OpenFile();
                txtFile.Text = fileBrowser.FileName;

                image = Bitmap.FromStream(sImage);

                frmImage = new frmImage();
                frmImage.BackgroundImage = image;
                frmImage.Width = image.Width;
                frmImage.Height = image.Height;

                frmImage.Show();
            }
        }

        private Bitmap RotateImage(Image img, int rotationAngle)
        {

            // create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void trkRotation_Scroll(object sender, EventArgs e)
        {
            frmImage.BackgroundImage = RotateImage(image, trkRotation.Value * 10);
        }
    }
}
