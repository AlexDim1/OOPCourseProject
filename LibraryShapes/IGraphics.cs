using System.Drawing;

namespace OOPCourseProject.Shapes
{

    // To make the shapes library more independent, its Paint() methods need to be more abstract.
    // To achieve this the Paint() methods don't have an implementation of their own and instead call these IGraphics methods,
    // which contain the needed implementation depending on the project   
    public interface IGraphics
    {
        void DrawRectangle(bool selected, Color color, Color borderColor, int x, int y, int width, int height);
        void DrawTriangle(bool selected, Color color, Color borderColor, Point location, Point[] vertices);
        void DrawCircle(bool selected, bool paintLoc, Color color, Color borderColor, Point location, int radius);
    }
}
