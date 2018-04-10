using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace OverScreen
{
    public partial class frmMain : Form
    {
        public Image image;

        private OverScreen overScreen;

        private Form frmImage;

        private String path;

        public frmMain()
        {
            InitializeComponent();

            overScreen = new OverScreen();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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

        private void mniScreenCapture_Click(object sender, EventArgs e)
        {
            CaptureScreen();
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
            if (frmImage != null)
            {
                frmImage.Opacity = trbOpacity.Value * 000.01d;
            }
        }

        private void trkRotation_Scroll(object sender, EventArgs e)
        {
            if (image != null)
            {
                frmImage.BackgroundImage = RotateImage(image, trkRotation.Value * 10);
            }
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

            // Create an empty Bitmap image.
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            // Turn the Bitmap into a Graphics object.
            Graphics gfx = Graphics.FromImage(bmp);

            // Now we set the rotation point to the center of our image.
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            // Rotate the image.
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            // Set the InterpolationMode to HighQualityBicubic so to ensure a high quality image once it is transformed to the specified size.
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Now draw our new image onto the graphics object.
            gfx.DrawImage(img, new Point(0, 0));

            // Dispose of our Graphics object.
            gfx.Dispose();

            // Return the image.
            return bmp;
        }

        public void CaptureScreen()
        {
            String filename = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

            try
            {
                // Get access to documents folder.
                FileIOPermission ioPerm = new FileIOPermission(FileIOPermissionAccess.Read, path);
                ioPerm.Demand();

                string filePath = Path.Combine(path, filename);

                // Get permission to write the screenshot file.
                FileIOPermission writeAccess = new FileIOPermission(FileIOPermissionAccess.AllAccess, filePath);
                writeAccess.Demand();

                // Debug.
                Console.WriteLine("Read access is permitted: {0} => {1}", path, SecurityManager.IsGranted(ioPerm));
                Console.WriteLine("Write backup file is permitted: {0} => {1}", filePath, SecurityManager.IsGranted(writeAccess));

                // Minimize control window before take the screenshot.
                this.WindowState = FormWindowState.Minimized;
                // Sleep for a quarter of secont to give it time to completely hide.
                System.Threading.Thread.Sleep(250);

                Rectangle bounds = Screen.GetBounds(Point.Empty);
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                    }
                    
                         
                    bitmap.Save(filePath, ImageFormat.Png);

                    // Restore window position.
                    this.WindowState = FormWindowState.Normal;
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.ToString());
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }            
        }
        
    }
}
