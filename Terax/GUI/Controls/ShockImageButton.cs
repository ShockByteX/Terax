using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Terax.GUI.Controls
{
    public partial class ShockImageButton : UserControl
    {
        #region Fields
        private ImageAttributes imgAttributes = new ImageAttributes();
        private Rectangle rectMin, rectMax, rectCurrent;
        private Image image = null;
        private int zoom = 2, animationStep = 1;
        private bool animated = true;
        private bool mouseEnter;
        #endregion
        #region Properties
        public Image Image { get => image; set { image = value; Invalidate(); } }
        public int Zoom { get => zoom; set { zoom = value; UpdateControl(); } }
        public bool Animated { get => animated; set => animated = value; }
        public int AnimationInterval { get => tmrAnimation.Interval; set => tmrAnimation.Interval = value; }
        public int AnimationStep { get => animationStep; set => animationStep = value; }
        public int ImageWidth => rectMin.Width;
        public int ImageHeight => rectMin.Height;
        #endregion
        #region Constructors
        public ShockImageButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            imgAttributes.SetWrapMode(WrapMode.TileFlipXY);
            UpdateControl();
        }
        #endregion
        #region [PRIVATE]Methods
        private void UpdateControl()
        {
            int doubleZoom = zoom * 2;
            rectMax = new Rectangle(0, 0, Width, Height);
            rectMin = new Rectangle(zoom, zoom, Width - doubleZoom, Height - doubleZoom);
            rectCurrent = rectMin;
            Invalidate();
        }
        #endregion
        #region [PROTECTED]Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            if (image == null) return;
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(image, rectCurrent, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAttributes);
        }
        protected override void OnMouseEnter(EventArgs e) { if (animated) { mouseEnter = true; if (!tmrAnimation.Enabled) tmrAnimation.Start(); } else { rectCurrent = rectMax; Invalidate(); } }
        protected override void OnMouseLeave(EventArgs e) { if (animated) { mouseEnter = false; if (!tmrAnimation.Enabled) tmrAnimation.Start(); } else { rectCurrent = rectMin; Invalidate(); } }
        protected override void OnResize(EventArgs e) { base.OnResize(e); UpdateControl(); }
        #endregion
        #region [PRIVATE]Timers
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            int doubleStep = animationStep * 2;
            if (mouseEnter && rectCurrent.Size != rectMax.Size)
            {
                int nWidth = rectCurrent.Width + doubleStep;
                int nHeight = rectCurrent.Height + doubleStep;
                if (nWidth < Width && nHeight < Height) rectCurrent = new Rectangle(rectCurrent.X - animationStep, rectCurrent.Y - animationStep, nWidth, nHeight); else { rectCurrent = rectMax; tmrAnimation.Stop(); }
            }
            else if (!mouseEnter && rectCurrent.Size != rectMin.Size)
            {
                int nWidth = rectCurrent.Width - doubleStep;
                int nHeight = rectCurrent.Height - doubleStep;
                if (nWidth > rectMin.Width && nHeight > rectMin.Height) rectCurrent = new Rectangle(rectCurrent.X + animationStep, rectCurrent.Y + animationStep, nWidth, nHeight); else { rectCurrent = rectMin; tmrAnimation.Stop(); }
            }
            Invalidate();
        }
        #endregion
    }
}