using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentation.Public
{
    public partial class RoundBox : UserControl
    {
        #region VARS
        private Color fillColor = Color.Blue;
        private readonly Brush activeBrush = Brushes.DimGray;
        private readonly Brush nonactiveBrush = Brushes.Brown;// DarkGray;
        private bool isActive = false;
        #endregion

        public RoundBox()
        {
            InitializeComponent();            
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public bool IsArrowVisible
        {
            get
            {
                return picArrow.Visible;
            }
            set
            {
                picArrow.Visible = value;
            }
        }

        public Color FillColor
        {
            get
            {
                return fillColor;
            }
            set
            {
                fillColor = value;
            }
        }

        private void RoundBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            const float radius = 5.675F;
            const int X = 0;
            const int Y = 0;
            int width = this.Width-4;
            int height = this.Height-8;
            string text = this.Text;

            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.FillPath(new SolidBrush(fillColor), gp);
            g.DrawPath(new Pen((isActive ? activeBrush : nonactiveBrush), 0.5F), gp);

            Font font = new Font(new Font("B Nazanin",10), isActive ? FontStyle.Bold : FontStyle.Regular);
            g.DrawString(text,
                    font,
                    new SolidBrush(Color.FromArgb((byte)~fillColor.R, (byte)~fillColor.G, (byte)~fillColor.B)),
                    new Point(X + width / 2 - TextRenderer.MeasureText(text, font).Width / 2 + 2, Y + height / 2 - 7));

            gp.Dispose();
        }

        private void RoundBox_Leave(object sender, EventArgs e)
        {
            isActive = false;
            Invalidate();
        }

        private void RoundBox_Enter(object sender, EventArgs e)
        {
            isActive = true;
            Invalidate();
        }
    }
}
