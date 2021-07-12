using System;
using System.Drawing;

namespace OOPCourseProject.Shapes
{
    [Serializable]
    public abstract class Shape
    {
        public Point Location { get; set; }
        public Point PrevLoc { get; set; }
        public Color Color { get; set; }
        public Color BorderColor { get; set; }
        public bool Selected { get; set; }

        public abstract double CalculateArea();
        public abstract void Paint(IGraphics g);
        public abstract bool Contains(Point p);                 // determines whether a point is inside of the shape
        public abstract bool Intersects(Rectangle rectangle);   // determines whether the selection frame is intersecting with the shape
        public abstract void Move(Point newLocation);
    }
}
