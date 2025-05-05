using System.Drawing.Drawing2D;

namespace ProductExport.CustomComponents
{
    internal class SideBar_Gradient : Panel
    {
        public Color GradientTop { get; set; }
        public Color GradientBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new(ClientRectangle, GradientTop, GradientBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, ClientRectangle);
            base.OnPaint(e);
        }

    }
}
