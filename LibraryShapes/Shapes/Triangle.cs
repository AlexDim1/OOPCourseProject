using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace OOPCourseProject.Shapes
{
    [Serializable]
    public class Triangle : Shape
    {
        public Triangle(Point[] vertices)
        {
            this.vertices = vertices;

            UpdateLocation();
        }

        public Point[] vertices { get; set; } 

        public override double CalculateArea()
        {
            // shoelace formula
            double result = Math.Abs(
                (vertices[0].X - vertices[2].X)
                * (vertices[1].Y - vertices[0].Y)
                - (vertices[0].X - vertices[1].X)
                * (vertices[2].Y - vertices[0].Y)) / 2;

            return result;
        }

        public override void Paint(IGraphics g)
        {
            g.DrawTriangle(Selected, Color, BorderColor, Location, vertices);
        }

        public override void Move(Point newLocation)
        {
            // Because for the other shapes the location is used for calculating all other points
            // we can move only the location
            // But here we need to move all vertices of the triangle simultaneously to keep its shape

            Location = newLocation;

            int dx = newLocation.X - PrevLoc.X;
            int dy = newLocation.Y - PrevLoc.Y;

            if (dx == 0 && dy == 0)
                return;

            for(int i = 0; i < vertices.Length; i++)
            {
                vertices[i].X += dx;
                vertices[i].Y += dy;
            }

            PrevLoc = Location;
        }

        public override bool Contains(Point p)
        {
            var v1 = vertices[0];
            var v2 = vertices[1];
            var v3 = vertices[2];

            var s = v1.Y * v3.X - v1.X * v3.Y + (v3.Y - v1.Y) * p.X + (v1.X - v3.X) * p.Y;
            var t = v1.X * v2.Y - v1.Y * v2.X + (v1.Y - v2.Y) * p.X + (v2.X - v1.X) * p.Y;

            if ((s < 0) != (t < 0))
                return false;

            var A = -v2.Y * v3.X + v1.Y * (v3.X - v2.X) + v1.X * (v2.Y - v3.Y) + v2.X * v3.Y;

            return A < 0 ?
                (s <= 0 && s + t >= A):
                (s >= 0 && s + t <= A);
        }

        public override bool Intersects(Rectangle rectangle)
        {
            foreach (var v in vertices)
                if (v.X > rectangle.Location.X &&
                    v.X < rectangle.Location.X + rectangle.Width &&
                    v.Y > rectangle.Location.Y &&
                    v.Y < rectangle.Location.Y + rectangle.Height)
                    return true;

            return false;
        }

        public void UpdateLocation()
        {
            // location is the centroid of the triangle
            // which we need to calculate every time any of the vertices is changed

            var lx = vertices.Sum(v => v.X) / 3;
            var ly = vertices.Sum(v => v.Y) / 3;

            Location = new Point(lx, ly);
        }
    }
}
