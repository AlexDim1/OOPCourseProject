
namespace OOPCourseProject.PropForms
{
    partial class FormCrcProp
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonBColor = new System.Windows.Forms.Button();
            this.labelBColor = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(237, 11);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(63, 30);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(9, 11);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.numericUpDownRadius);
            this.panel1.Controls.Add(this.numericUpDownY);
            this.panel1.Controls.Add(this.numericUpDownX);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.labelRadius);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 221);
            this.panel1.TabIndex = 2;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(41, 133);
            this.labelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(41, 110);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X";
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(50, 28);
            this.numericUpDownRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            1535,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownRadius.TabIndex = 5;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(59, 129);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            778,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownY.TabIndex = 4;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(59, 106);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.labelLocation.Location = new System.Drawing.Point(17, 82);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(114, 17);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location(Center)";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius.Location = new System.Drawing.Point(47, 9);
            this.labelRadius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(56, 17);
            this.labelRadius.TabIndex = 1;
            this.labelRadius.Text = "Radius:";
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(27, 103);
            this.labelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(42, 20);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Color:";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(74, 97);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(42, 33);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonBColor
            // 
            this.buttonBColor.Location = new System.Drawing.Point(87, 38);
            this.buttonBColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBColor.Name = "buttonBColor";
            this.buttonBColor.Size = new System.Drawing.Size(42, 33);
            this.buttonBColor.TabIndex = 4;
            this.buttonBColor.UseVisualStyleBackColor = true;
            this.buttonBColor.Click += new System.EventHandler(this.buttonBColor_Click);
            // 
            // labelBColor
            // 
            this.labelBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBColor.Location = new System.Drawing.Point(27, 43);
            this.labelBColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBColor.Name = "labelBColor";
            this.labelBColor.Size = new System.Drawing.Size(56, 20);
            this.labelBColor.TabIndex = 5;
            this.labelBColor.Text = "Border:";
            this.labelBColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 221);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(310, 50);
            this.panelButtons.TabIndex = 6;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelBColor);
            this.panelColor.Controls.Add(this.buttonColor);
            this.panelColor.Controls.Add(this.buttonBColor);
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColor.Location = new System.Drawing.Point(155, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(155, 221);
            this.panelColor.TabIndex = 7;
            // 
            // FormCrcProp
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(310, 271);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrcProp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Circle Properties";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonBColor;
        private System.Windows.Forms.Label labelBColor;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelColor;
    }
}