using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPCourseProject.PropForms
{
    public partial class FormTriProp : Form
    {
        public FormTriProp()
        {
            InitializeComponent();
        }

        private Point _v1;
        private Point _v2;
        private Point _v3;
        private Color _color;
        private Color _bColor;

        public Point V1
        {
            get => _v1;
            set
            {
                _v1 = value;
                numericUpDownV1X.Value = _v1.X;
                numericUpDownV1Y.Value = _v1.Y;
            }
        }

        public Point V2
        {
            get => _v2;
            set
            {
                _v2 = value;
                numericUpDownV2X.Value = _v2.X;
                numericUpDownV2Y.Value = _v2.Y;
            }
        }

        public Point V3
        {
            get => _v3;
            set
            {
                _v3 = value;
                numericUpDownV3X.Value = _v3.X;
                numericUpDownV3Y.Value = _v3.Y;
            }
        }

        public Color triColor
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

        public Color triBColor
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
            _v1.X = (int)numericUpDownV1X.Value;
            _v1.Y = (int)numericUpDownV1Y.Value;

            _v2.X = (int)numericUpDownV2X.Value;
            _v2.Y = (int)numericUpDownV2Y.Value;

            _v3.X = (int)numericUpDownV3X.Value;
            _v3.Y = (int)numericUpDownV3Y.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            triColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : triColor;
        }

        private void buttonBColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            triBColor = cd.ShowDialog() == DialogResult.OK
                ? cd.Color
                : triBColor;
        }
    }
}
