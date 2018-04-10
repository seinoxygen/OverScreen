using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverScreen
{
    public partial class frmImage : Form
    { 

        private const int WM_NCHITTEST = 0x84;
        private const int WM_MOUSEMOVE = 0x0200;

        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int WM_CONTEXTMENU = 0x007B;

        private const int WM_NCRBUTTONDOWN = 0xa4;

        const UInt32 HTLEFT = 10;
        const UInt32 HTRIGHT = 11;
        const UInt32 HTBOTTOMRIGHT = 17;
        const UInt32 HTBOTTOM = 15;
        const UInt32 HTBOTTOMLEFT = 16;
        const UInt32 HTTOP = 12;
        const UInt32 HTTOPLEFT = 13;
        const UInt32 HTTOPRIGHT = 14;

        const int RESIZE_HANDLE_SIZE = 10;


        private int tolerance = 16;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                    {
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    }
                    else
                    {
                        m.Result = (IntPtr)(HT_CAPTION);

                    }
                    
                    break;
                case WM_NCRBUTTONDOWN:
                    var pos = new Point(m.LParam.ToInt32());
                    ctxMenu.Show(pos);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        public frmImage()
        {
            InitializeComponent();
        }


        private void ctxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 75 * 000.01d;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ContextMenuStrip = ctxMenu;
        }
    }
}
