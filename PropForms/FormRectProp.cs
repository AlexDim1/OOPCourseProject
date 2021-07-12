using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPCourseProject.PropForms
{
    public partial class FormRectProp : Form
    {
        public FormRectProp()
        {
            InitializeComponent();
        }

        // the shape's data
        private Point _location;
        private int _width;
        private int _height;
        private Color _color;
        private Color _bColor;

        public int rectWidth
        {
            get => _width;
            set
            {
                _width = value;

                // when the form opens, the controls need to receive the shape's data
                numericUpDownWidth.Value = _width;
            }
        }

        public int rectHeight
        {
            get => _height;
            set
            {
                _height = value;
                numericUpDownHeight.Value = _height;
            }
        }

        public Point rectLocation
        {
            get => _location;
            set
            {
                _location = value;
                numericUpDownX.Value = _location.X;
                numericUpDownY.Value = _location.Y;
            }
        }

        public Color rectColor
        {
            get => _color;
            set
            {
                _color = value;
                buttonColor.BackColor = _color.IsEmpty
                    ? BackColor
                    : _color;
            }
        }

        public Color rectBColor
        {
            get => _bColor;
            set
            {
                _bColor = value;
                buttonBColor.BackColor = _bColor.IsEmpty
                    ? BackColor
                    : _bColor;
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            // the new values are saved
            _width = (int)numericUpDownWidth.Value;
            _height = (int)numericUpDownHeight.Value;
            _location.X = (int)numericUpDownX.Value;
            _location.Y = (int)numericUpDownY.Value;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            rectColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : rectColor;
        }

        private void buttonBColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            rectBColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : rectBColor;
        }
    }
}
