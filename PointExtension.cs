using System.Drawing;
using System.Drawing.Drawing2D;

namespace OOPCourseProject
{
    public static class PointExtension
    {
        // some Points need to be able to be drawn on the Form
        public static void Paint(this Point p, Graphics g)
        {
            using (var brush = new SolidBrush(Color.Red))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(brush, p.X - 2, p.Y - 2, 4, 4);
            }
        }
    }
}
