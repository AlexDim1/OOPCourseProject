using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPCourseProject.PropForms
{
    public partial class FormCrcProp : Form
    {
        public FormCrcProp()
        {
            InitializeComponent();
        }

        private Point _center;
        private int _radius;
        private Color _color;
        private Color _bColor;

        public Point Center
        {
            get => _center;
            set
            {
                _center = value;
                numericUpDownX.Value = _center.X;
                numericUpDownY.Value = _center.Y;
            }
        }

        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                numericUpDownRadius.Value = (decimal)_radius;
            }
        }

        public Color CrcColor
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

        public Color CrcBColor
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Radius = (int)numericUpDownRadius.Value;
            _center.X = (int)numericUpDownX.Value;
            _center.Y = (int)numericUpDownY.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            CrcColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : CrcColor;
        }

        private void buttonBColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            CrcBColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : CrcBColor;
        }
    }
}
