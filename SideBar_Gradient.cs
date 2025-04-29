using System.Drawing.Drawing2D;

namespace ProductExport
{
    internal class SideBar_Gradient : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new(this.ClientRectangle, gradientTop, gradientBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
