using System;
using System.Drawing;

namespace OOPCourseProject.Shapes
{
    [Serializable]
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public bool PaintLoc { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override bool Contains(Point p)
        {
            // x^2 + y^2 < r^2
            return Math.Pow(p.X - Location.X, 2) + Math.Pow(p.Y - Location.Y, 2) < Radius * Radius;
        }

        public override bool Intersects(Rectangle rectangle)
        {
            return Location.X > rectangle.Location.X &&
                Location.X < rectangle.Location.X + rectangle.Width &&
                Location.Y > rectangle.Location.Y &&
                Location.Y < rectangle.Location.Y + rectangle.Height;
        }

        public override void Move(Point newLocation)
        {
            Location = newLocation;
        }

        public override void Paint(IGraphics g)
        {
            g.DrawCircle(Selected, PaintLoc, Color, BorderColor, Location, Radius);
        }
    }
}
