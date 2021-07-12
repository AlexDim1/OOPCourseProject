using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using OOPCourseProject.Shapes;
using OOPCourseProject.PropForms;
using Rectangle = OOPCourseProject.Shapes.Rectangle;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPCourseProject
{
    public enum Mode
    {
        Rectangle = 0,
        Triangle = 1,
        Circle = 2,
        Move = 3
    }

    public partial class FormScene : Form, IGraphics
    {
        private List<Shape> _sceneObjects = new List<Shape>();

        private Graphics _graphics;

        // frames used for visualizing shapes while creating
        private Rectangle _frame;
        private Circle _frCircle;
        private Rectangle _frSelect;

        private bool _mouseCaught;
        private Point _mouseCaughtLocation;

        private bool _saved;

        private Color _selectedColor;

        // stores the vertices of a triangle until it can be drawn
        private List<Point> _vertices = new List<Point>();

        private Mode _mode;
        private Mode _prevMode;

        private Mode Mode
        {
            get => _mode;
            set
            {
                _mode = value;

                // every time the mode is changed the label needs to change as well
                labelMode.Text = "Mode: " + value.ToString();
            }
        }

        public FormScene()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _graphics = e.Graphics;

            for (int i = _sceneObjects.Count - 1; i >= 0; i--)
                _sceneObjects[i].Paint(this);

            if (_mouseCaught && _frSelect != null)
                _frSelect.Paint(this);

            if (_mouseCaught && _frame != null)
                _frame.Paint(this);

            if (_mouseCaught && _frCircle != null)
            {
                _frCircle.Paint(this);
                using(var pen = new Pen(Color.Black))
                {
                    pen.DashStyle = DashStyle.Dash;
                    e.Graphics.DrawLine(pen, _frCircle.Location, PointToClient(MousePosition));
                }
            }

            // Every time the form is redrawn the area of the shapes needs an update
            UpdateLabelArea();

            _graphics = null;
        }

        private Rectangle CreateRectangleFrame(Point location)
        {
            var frame = new Rectangle()
            {
                // Location is always the top left corner of the rectangle
                Location = new Point(
                    Math.Min(_mouseCaughtLocation.X, location.X),
                    Math.Min(_mouseCaughtLocation.Y, location.Y)
                    ),

                Width = Math.Abs(_mouseCaughtLocation.X - location.X),

                Height = Math.Abs(_mouseCaughtLocation.Y - location.Y),

                BorderColor = Color.Black
            };

            return frame;
        }

        private Circle CreateCircleFrame(Point location)
        {
            var c = new Circle()
            {
                Location = _mouseCaughtLocation,

                // Distance between the current mouse location and center of the circle
                Radius = (int)Math.Sqrt(
                    Math.Pow(location.X - _mouseCaughtLocation.X, 2) +
                    Math.Pow(location.Y - _mouseCaughtLocation.Y, 2)),

                BorderColor = Color.Black,

                // While the circle is being created its center needs to be drawn on the form
                PaintLoc = true 
            };
            return c;
        }

        private Triangle CreateTriangle()
        {
            var t = new Triangle(_vertices.ToArray())
            {
                Color = _selectedColor
            };
            _vertices.Clear();
            return t;
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseCaught = true;
            _mouseCaughtLocation = e.Location;
            _frame = null;
            _frCircle = null;
            _frSelect = null;

            if (e.Button == MouseButtons.Left)
            {
                if (Mode == Mode.Move)
                {
                    Mode = _prevMode;
                }
                else
                {
                    _vertices.Clear();

                    foreach (var s in _sceneObjects)
                        s.Selected = false;

                    var selectedShape = _sceneObjects
                        .FirstOrDefault(s => s.Contains(e.Location));

                    if (selectedShape != null)
                        selectedShape.Selected = true;
                }
            }
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseCaught = false;

            if (e.Button == MouseButtons.Right)
            {
                if (Mode == Mode.Rectangle && _frame != null)       // A rectangle is created from the frame
                {
                    _frame.Color = _selectedColor;

                    _frame.BorderColor = _selectedColor.IsEmpty ?
                        Color.Black :
                        _selectedColor;

                    _sceneObjects.Insert(0, _frame);

                    Invalidate();
                }
                else if (Mode == Mode.Circle && _frCircle != null)  // A circle is created from the frame
                {
                    _frCircle.Color = _selectedColor;

                    _frCircle.BorderColor = _selectedColor.IsEmpty ?
                        Color.Black :
                        _selectedColor;

                    _sceneObjects.Insert(0, _frCircle);

                    _frCircle.PaintLoc = false;

                    Invalidate();
                }
                else if (Mode == Mode.Triangle)                     
                {
                    // A point is created and added to _vertices

                    var v = new Point(e.X, e.Y);
                    _vertices.Add(v);
                    v.Paint(CreateGraphics());

                    if (_vertices.Count == 3)                       // A triangle is created from the points
                    {
                        var t = CreateTriangle();

                        t.BorderColor = _selectedColor.IsEmpty 
                            ? Color.Black 
                            :_selectedColor;

                        _sceneObjects.Insert(0, t);

                        Invalidate();
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
                Invalidate();
        }

        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            // Every time the mouse is moved the Cursor Pos labels need an update
            UpdateMousePositionLabels();

            // Mouse move is the most often called event so the info label is always up to date 
            UpdateInfo();                                                                                 

            if (!_mouseCaught && Mode != Mode.Move)
                return;

            if (e.Button == MouseButtons.Left)                      // Creation of the frame used for selecting
            {
                _frSelect = CreateRectangleFrame(e.Location);
                Invalidate();

                foreach (var s in _sceneObjects)
                {
                    if (s.Intersects(_frSelect))
                        s.Selected = true;
                    else
                        s.Selected = false;
                }
            }
            else if (e.Button == MouseButtons.Right)                // Creation of the frames
            {
                if (Mode == Mode.Rectangle)
                {
                    _frame = CreateRectangleFrame(e.Location);
                    Invalidate();
                }
                else if (Mode == Mode.Circle)
                {
                    _frCircle = CreateCircleFrame(e.Location);
                    Invalidate();
                }
            }
            else if (Mode == Mode.Move)                             // Moves the selected shape 
            {
                MoveShape(e.Location);

                Invalidate();
            }
        }

        private void UpdateLabelArea()
        {
            var selectedShapes = GetMultipleSelected();

            // if no shapes are selected the total area of all is shown
            // otherwise the area of the selected shapes is shown
            if (selectedShapes.Length == 0)
            {
                double totalArea = _sceneObjects.Sum(s => s.CalculateArea());
                toolStripStatusLabelArea.Text = "Area of all shapes: " 
                    + Math.Round(totalArea, 2).ToString();
            }
            else
            {
                toolStripStatusLabelArea.Text = "Area of selected shape(s): " 
                    + Math.Round(selectedShapes.Sum(s => s.CalculateArea()), 2).ToString();
            }

        }

        private void UpdateMousePositionLabels()
        {
            var currentPos = PointToClient(MousePosition);

            toolStripStatusLabelMouseX.Text = "X: " + currentPos.X.ToString();
            toolStripStatusLabelMouseY.Text = "Y: " + currentPos.Y.ToString();
        }

        private void UpdateInfo()
        {
            switch (Mode)
            {
                case Mode.Rectangle:
                    labelDrawInfo.Text = "Hold Right Click and drag to create a Rectangle";
                    break;
                case Mode.Circle:
                    labelDrawInfo.Text = "Hold Right Click and drag to create a Circle";
                    break;
                case Mode.Triangle:
                    labelDrawInfo.Text = "Right Click to select the vertices for the Triangle. Left Click to cancel selection.";
                    break;
                case Mode.Move:
                    labelDrawInfo.Text = "Move the mouse to move the Shape. Press M or Left Mouse Button to exit Move Mode.";
                    break;
            }
        }

        private void Delete()
        {
            for (int i = _sceneObjects.Count - 1; i >= 0; i--)
                if (_sceneObjects[i].Selected)
                    _sceneObjects.RemoveAt(i);

            Invalidate();
        }

        private void OpenProperties(Shape s)
        {
            // here we open the respective Properties form and transfer the shape's data to it and then back

            if(s is Rectangle)
            {
                var rect = (Rectangle)s;
                var fp = new FormRectProp();
                fp.rectLocation = rect.Location;
                fp.rectWidth = rect.Width;
                fp.rectHeight = rect.Height;
                fp.rectColor = rect.Color;
                fp.rectBColor = rect.BorderColor;

                if(fp.ShowDialog() == DialogResult.OK)
                {
                    rect.Location = fp.rectLocation;
                    rect.Width = fp.rectWidth;
                    rect.Height = fp.rectHeight;
                    rect.Color = fp.rectColor;
                    rect.BorderColor = fp.rectBColor;
                }
            } 
            else if(s is Triangle)
            {
                var tr = (Triangle)s;
                var fp = new FormTriProp();
                fp.V1 = tr.vertices[0];
                fp.V2 = tr.vertices[1];
                fp.V3 = tr.vertices[2];
                fp.triColor = tr.Color;
                fp.triBColor = tr.BorderColor;

                if (fp.ShowDialog() == DialogResult.OK)
                {
                    tr.vertices[0] = fp.V1;
                    tr.vertices[1] = fp.V2;
                    tr.vertices[2] = fp.V3;
                    tr.UpdateLocation();
                    tr.Color = fp.triColor;
                    tr.BorderColor = fp.triBColor;
                }
            }
            else if(s is Circle)
            {
                var crc = (Circle)s;
                var fp = new FormCrcProp();
                fp.Center = crc.Location;
                fp.Radius = crc.Radius;
                fp.CrcColor = crc.Color;
                fp.CrcBColor = crc.BorderColor;

                if(fp.ShowDialog() == DialogResult.OK)
                {
                    crc.Location = fp.Center;
                    crc.Radius = fp.Radius;
                    crc.Color = fp.CrcColor;
                    crc.BorderColor = fp.CrcBColor;
                }
            }

            Invalidate();
        }

        private void OpenHelp()
        {
            var fh = new FormHelp();
            fh.Show();
        }

        private void SelectColor()
        {
            var fc = new ColorDialog();

            if (fc.ShowDialog() == DialogResult.OK)
            {
                _selectedColor = fc.Color;
                buttonColor.Text = "";
                buttonColor.BackColor = _selectedColor;
            }
        }

        private void SaveFile()
        {
            var fs = new SaveFileDialog();
            fs.Title = "Save Scene";
            fs.Filter = "Scene files (.scene)|*.scene";
            fs.DefaultExt = ".scene";
            fs.OverwritePrompt = true;

            if (fs.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();

                using(var stream = fs.OpenFile())
                    formatter.Serialize(stream, _sceneObjects);

                Text = fs.FileName;
                _saved = true;
            }
        }

        private void LoadFile()
        {
            var fo = new OpenFileDialog();
            fo.Title = "Load Scene";
            fo.Filter = "Scene files (.scene)|*.scene";
            
            var formatter = new BinaryFormatter();

            if (fo.ShowDialog() == DialogResult.OK)
            {
                using (var stream = fo.OpenFile())
                    _sceneObjects = (List<Shape>)formatter.Deserialize(stream);

                Text = fo.FileName;
            }

            Invalidate();
        }

        private DialogResult ShowSavePrompt()
        {
            return MessageBox.Show(
                "Are you sure you want to exit without saving?",
                "Warning!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        private void MoveShape(Point newLocation)
        {
            var selectedShape = GetOneSelected();
 
            Cursor.Position = PointToScreen(newLocation);

            selectedShape.Move(newLocation);
        }

        private Shape[] GetMultipleSelected()
        {
            return _sceneObjects
                .Where(s => s.Selected)
                .ToArray();
        }

        private Shape GetOneSelected()
        {
            // if multiple are selected returns the most recently created one
            return _sceneObjects
                .FirstOrDefault(s => s.Selected);
        }

        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && Mode != Mode.Move)
            {
                var selectedShape = GetOneSelected();

                OpenProperties(selectedShape);
            }
            else if (e.KeyCode == Keys.Delete && Mode != Mode.Move)
            {
                Delete();
            }
            else if (e.KeyCode == Keys.M)
            {
                // the mode before M is pressed is saved
                if(Mode != Mode.Move)
                    _prevMode = Mode;

                var selectedShape = GetOneSelected();

                if (Mode != Mode.Move && selectedShape != null)
                {
                    Mode = Mode.Move;

                    selectedShape.PrevLoc = selectedShape.Location;

                    // the cursor is moved to the shape's location
                    Cursor.Position = PointToScreen(selectedShape.Location);
                }
                else
                    // return to the mode before M was pressed
                    Mode = _prevMode;
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                if (_sceneObjects.All(s => s.Selected))
                    foreach (var s in _sceneObjects)
                        s.Selected = false;
                else
                    foreach (var s in _sceneObjects)
                        s.Selected = true;

                Invalidate();
            }
            else if (e.Control && e.KeyCode == Keys.S && !_mouseCaught)
            {
                SaveFile();
            }
            else if (e.KeyCode == Keys.Tab && Mode != Mode.Move && !_mouseCaught)
            {
                // switches between all modes except Move

                Mode++;

                if ((int)Mode > 2)
                    Mode = 0;
            }
            else if (e.KeyCode == Keys.C && Mode != Mode.Move && !_mouseCaught)
            {
                SelectColor();
            }
            else if (e.KeyCode == Keys.H)
            {
                OpenHelp();
            }
            else
                return;
        }

        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            var selectedShape = GetOneSelected();

            OpenProperties(selectedShape);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            SelectColor();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void newSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_saved && _sceneObjects.Count > 0)
            {
                if (ShowSavePrompt() == DialogResult.No)
                    return;

                _sceneObjects.Clear();
                Text = "Scene";
                _saved = false;
                Invalidate();
            }
            else
            {
                _sceneObjects.Clear();
                Text = "Scene";
                _saved = false;
                Invalidate();
            }
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.Rectangle;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.Triangle;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.Circle;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelp();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_saved || _sceneObjects.Count == 0)
                return;
            else
            {
                if (ShowSavePrompt() != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        // The drawing methods from IGraphics using System.Drawing and the Graphics object in this case

        public void DrawRectangle(bool selected, Color color, Color borderColor, int x, int y, int width, int height)
        {
            if (_graphics != null)
            {
                if (color != null)
                    using (var brush = new SolidBrush(color))
                        _graphics.FillRectangle(brush, x, y, width, height);

                using (var pen = new Pen(borderColor))
                    _graphics.DrawRectangle(pen, x, y, width, height);

                if (selected)
                    using (var pen = new Pen(Color.Red, 3))
                        _graphics.DrawRectangle(pen, x, y, width, height);
            }
        }

        public void DrawTriangle(bool selected, Color color, Color borderColor, Point location, Point[] vertices)
        {
            if (_graphics != null)
            {
                _graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (color != null)
                    using (var brush = new SolidBrush(color))
                        _graphics.FillPolygon(brush, vertices);

                using (var pen = new Pen(borderColor))
                    _graphics.DrawPolygon(pen, vertices);

                if (selected)
                    using (var pen = new Pen(Color.Red, 3))
                    {
                        _graphics.DrawPolygon(pen, vertices);
                        location.Paint(_graphics);
                    }
            }
        }

        public void DrawCircle(bool selected, bool paintLoc, Color color, Color borderColor, Point location, int radius)
        {
            if (_graphics != null)
            {
                _graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (color != null)
                    using (var brush = new SolidBrush(color))
                        _graphics.FillEllipse(brush,
                            location.X - radius,
                            location.Y - radius,
                            radius * 2,
                            radius * 2);

                using (var pen = new Pen(borderColor))
                    _graphics.DrawEllipse(pen,
                        location.X - radius,
                        location.Y - radius,
                        radius * 2,
                        radius * 2);

                if (selected)
                    using (var pen = new Pen(Color.Red, 3))
                    {
                        _graphics.DrawEllipse(pen,
                        location.X - radius,
                        location.Y - radius,
                        radius * 2,
                        radius * 2);

                        location.Paint(_graphics);
                    }

                if (paintLoc)
                    location.Paint(_graphics);
            }
        }
    }
}
