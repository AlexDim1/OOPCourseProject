
namespace OOPCourseProject.PropForms
{
    partial class FormRectProp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelProps = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.panelLocation = new System.Windows.Forms.Panel();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelBColor = new System.Windows.Forms.Label();
            this.buttonBColor = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelProps.SuspendLayout();
            this.panelSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.panelLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProps
            // 
            this.panelProps.Controls.Add(this.panelSize);
            this.panelProps.Controls.Add(this.panelLocation);
            this.panelProps.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProps.Location = new System.Drawing.Point(0, 0);
            this.panelProps.Name = "panelProps";
            this.panelProps.Size = new System.Drawing.Size(155, 221);
            this.panelProps.TabIndex = 0;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.numericUpDownHeight);
            this.panelSize.Controls.Add(this.numericUpDownWidth);
            this.panelSize.Controls.Add(this.labelHeight);
            this.panelSize.Controls.Add(this.labelWidth);
            this.panelSize.Controls.Add(this.labelSize);
            this.panelSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSize.Location = new System.Drawing.Point(0, 106);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(155, 115);
            this.panelSize.TabIndex = 1;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(106, 61);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            778,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownHeight.TabIndex = 4;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(7, 61);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1535,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownWidth.TabIndex = 3;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(103, 40);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 15);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(4, 40);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(41, 15);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(59, 12);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(35, 17);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size";
            // 
            // panelLocation
            // 
            this.panelLocation.Controls.Add(this.numericUpDownY);
            this.panelLocation.Controls.Add(this.labelY);
            this.panelLocation.Controls.Add(this.labelX);
            this.panelLocation.Controls.Add(this.numericUpDownX);
            this.panelLocation.Controls.Add(this.labelLocation);
            this.panelLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocation.Location = new System.Drawing.Point(0, 0);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(155, 106);
            this.panelLocation.TabIndex = 0;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(27, 62);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            778,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownY.TabIndex = 4;
            // 
            // labelY
            // 
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(6, 63);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(16, 21);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(6, 38);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(16, 21);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X:";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(27, 38);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1535,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownX.TabIndex = 3;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLocation.Location = new System.Drawing.Point(47, 6);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(62, 17);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(237, 11);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(63, 30);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(9, 11);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(74, 97);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(42, 33);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(27, 103);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 20);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Color:";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBColor
            // 
            this.labelBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBColor.Location = new System.Drawing.Point(27, 43);
            this.labelBColor.Name = "labelBColor";
            this.labelBColor.Size = new System.Drawing.Size(56, 20);
            this.labelBColor.TabIndex = 6;
            this.labelBColor.Text = "Border:";
            this.labelBColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBColor
            // 
            this.buttonBColor.Location = new System.Drawing.Point(87, 38);
            this.buttonBColor.Name = "buttonBColor";
            this.buttonBColor.Size = new System.Drawing.Size(42, 33);
            this.buttonBColor.TabIndex = 7;
            this.buttonBColor.UseVisualStyleBackColor = true;
            this.buttonBColor.Click += new System.EventHandler(this.buttonBColor_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 221);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(310, 50);
            this.panelButtons.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelBColor);
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Controls.Add(this.buttonColor);
            this.panelColor.Controls.Add(this.buttonBColor);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColor.Location = new System.Drawing.Point(155, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(155, 221);
            this.panelColor.TabIndex = 9;
            // 
            // FormRectProp
            // 
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(310, 271);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelProps);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRectProp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rectangle Properties";
            this.panelProps.ResumeLayout(false);
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.panelLocation.ResumeLayout(false);
            this.panelLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProps;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Panel panelLocation;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelBColor;
        private System.Windows.Forms.Button buttonBColor;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelColor;
    }
}