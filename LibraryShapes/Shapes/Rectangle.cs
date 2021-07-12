using System;
using System.Drawing;

namespace OOPCourseProject.Shapes
{
    [Serializable]
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override bool Contains(Point p)
        {
            return
                Location.X < p.X && p.X < Location.X + Width &&
                Location.Y < p.Y && p.Y < Location.Y + Height;
        }

        public override bool Intersects(Rectangle rectangle)
        {
            return
                this.Location.X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < this.Location.X + this.Width &&
                this.Location.Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < this.Location.Y + this.Height;
        }

        public override void Move(Point newLocation)
        {
            Location = newLocation;
        }

        public override void Paint(IGraphics g)
        {
            g.DrawRectangle(Selected, Color, BorderColor, Location.X, Location.Y, Width, Height);
        }
    }
}
