
namespace OOPCourseProject.PropForms
{
    partial class FormTriProp
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
            this.labelLocation = new System.Windows.Forms.Label();
            this.panelProps = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.numericUpDownV1X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV1Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV2X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV2Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV3X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV3Y = new System.Windows.Forms.NumericUpDown();
            this.labelV3Y = new System.Windows.Forms.Label();
            this.labelV3X = new System.Windows.Forms.Label();
            this.labelV2Y = new System.Windows.Forms.Label();
            this.labelV2X = new System.Windows.Forms.Label();
            this.labelV1Y = new System.Windows.Forms.Label();
            this.labelV1X = new System.Windows.Forms.Label();
            this.labelV3 = new System.Windows.Forms.Label();
            this.labelV2 = new System.Windows.Forms.Label();
            this.labelV1 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonBColor = new System.Windows.Forms.Button();
            this.labelBColor = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV3X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV3Y)).BeginInit();
            this.panelColor.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(316, 14);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(84, 37);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 14);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 37);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLocation.Location = new System.Drawing.Point(37, 11);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(116, 20);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Move Vertices";
            // 
            // panelProps
            // 
            this.panelProps.Controls.Add(this.labelInfo);
            this.panelProps.Controls.Add(this.numericUpDownV1X);
            this.panelProps.Controls.Add(this.numericUpDownV1Y);
            this.panelProps.Controls.Add(this.numericUpDownV2X);
            this.panelProps.Controls.Add(this.numericUpDownV2Y);
            this.panelProps.Controls.Add(this.numericUpDownV3X);
            this.panelProps.Controls.Add(this.numericUpDownV3Y);
            this.panelProps.Controls.Add(this.labelV3Y);
            this.panelProps.Controls.Add(this.labelV3X);
            this.panelProps.Controls.Add(this.labelV2Y);
            this.panelProps.Controls.Add(this.labelV2X);
            this.panelProps.Controls.Add(this.labelV1Y);
            this.panelProps.Controls.Add(this.labelV1X);
            this.panelProps.Controls.Add(this.labelV3);
            this.panelProps.Controls.Add(this.labelV2);
            this.panelProps.Controls.Add(this.labelV1);
            this.panelProps.Controls.Add(this.labelLocation);
            this.panelProps.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProps.Location = new System.Drawing.Point(0, 0);
            this.panelProps.Margin = new System.Windows.Forms.Padding(0);
            this.panelProps.Name = "panelProps";
            this.panelProps.Size = new System.Drawing.Size(207, 272);
            this.panelProps.TabIndex = 3;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(4, 225);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(208, 17);
            this.labelInfo.TabIndex = 20;
            this.labelInfo.Text = "(Numbered in order of creation)";
            // 
            // numericUpDownV1X
            // 
            this.numericUpDownV1X.Location = new System.Drawing.Point(25, 60);
            this.numericUpDownV1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV1X.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownV1X.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDownV1X.Name = "numericUpDownV1X";
            this.numericUpDownV1X.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV1X.TabIndex = 14;
            // 
            // numericUpDownV1Y
            // 
            this.numericUpDownV1Y.Location = new System.Drawing.Point(25, 90);
            this.numericUpDownV1Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV1Y.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numericUpDownV1Y.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownV1Y.Name = "numericUpDownV1Y";
            this.numericUpDownV1Y.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV1Y.TabIndex = 15;
            // 
            // numericUpDownV2X
            // 
            this.numericUpDownV2X.Location = new System.Drawing.Point(132, 60);
            this.numericUpDownV2X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV2X.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownV2X.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDownV2X.Name = "numericUpDownV2X";
            this.numericUpDownV2X.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV2X.TabIndex = 16;
            // 
            // numericUpDownV2Y
            // 
            this.numericUpDownV2Y.Location = new System.Drawing.Point(132, 90);
            this.numericUpDownV2Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV2Y.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numericUpDownV2Y.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownV2Y.Name = "numericUpDownV2Y";
            this.numericUpDownV2Y.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV2Y.TabIndex = 17;
            // 
            // numericUpDownV3X
            // 
            this.numericUpDownV3X.Location = new System.Drawing.Point(76, 154);
            this.numericUpDownV3X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV3X.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownV3X.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDownV3X.Name = "numericUpDownV3X";
            this.numericUpDownV3X.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV3X.TabIndex = 18;
            // 
            // numericUpDownV3Y
            // 
            this.numericUpDownV3Y.Location = new System.Drawing.Point(76, 185);
            this.numericUpDownV3Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownV3Y.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numericUpDownV3Y.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownV3Y.Name = "numericUpDownV3Y";
            this.numericUpDownV3Y.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownV3Y.TabIndex = 19;
            // 
            // labelV3Y
            // 
            this.labelV3Y.AutoSize = true;
            this.labelV3Y.Location = new System.Drawing.Point(57, 187);
            this.labelV3Y.Name = "labelV3Y";
            this.labelV3Y.Size = new System.Drawing.Size(17, 17);
            this.labelV3Y.TabIndex = 12;
            this.labelV3Y.Text = "Y";
            // 
            // labelV3X
            // 
            this.labelV3X.AutoSize = true;
            this.labelV3X.Location = new System.Drawing.Point(57, 156);
            this.labelV3X.Name = "labelV3X";
            this.labelV3X.Size = new System.Drawing.Size(17, 17);
            this.labelV3X.TabIndex = 11;
            this.labelV3X.Text = "X";
            // 
            // labelV2Y
            // 
            this.labelV2Y.AutoSize = true;
            this.labelV2Y.Location = new System.Drawing.Point(109, 92);
            this.labelV2Y.Name = "labelV2Y";
            this.labelV2Y.Size = new System.Drawing.Size(17, 17);
            this.labelV2Y.TabIndex = 10;
            this.labelV2Y.Text = "Y";
            // 
            // labelV2X
            // 
            this.labelV2X.AutoSize = true;
            this.labelV2X.Location = new System.Drawing.Point(109, 62);
            this.labelV2X.Name = "labelV2X";
            this.labelV2X.Size = new System.Drawing.Size(17, 17);
            this.labelV2X.TabIndex = 9;
            this.labelV2X.Text = "X";
            // 
            // labelV1Y
            // 
            this.labelV1Y.AutoSize = true;
            this.labelV1Y.Location = new System.Drawing.Point(5, 92);
            this.labelV1Y.Name = "labelV1Y";
            this.labelV1Y.Size = new System.Drawing.Size(17, 17);
            this.labelV1Y.TabIndex = 7;
            this.labelV1Y.Text = "Y";
            // 
            // labelV1X
            // 
            this.labelV1X.AutoSize = true;
            this.labelV1X.Location = new System.Drawing.Point(5, 62);
            this.labelV1X.Name = "labelV1X";
            this.labelV1X.Size = new System.Drawing.Size(17, 17);
            this.labelV1X.TabIndex = 6;
            this.labelV1X.Text = "X";
            // 
            // labelV3
            // 
            this.labelV3.AutoSize = true;
            this.labelV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV3.Location = new System.Drawing.Point(83, 133);
            this.labelV3.Name = "labelV3";
            this.labelV3.Size = new System.Drawing.Size(27, 18);
            this.labelV3.TabIndex = 5;
            this.labelV3.Text = "V3";
            // 
            // labelV2
            // 
            this.labelV2.AutoSize = true;
            this.labelV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV2.Location = new System.Drawing.Point(136, 37);
            this.labelV2.Name = "labelV2";
            this.labelV2.Size = new System.Drawing.Size(27, 18);
            this.labelV2.TabIndex = 4;
            this.labelV2.Text = "V2";
            // 
            // labelV1
            // 
            this.labelV1.AutoSize = true;
            this.labelV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV1.Location = new System.Drawing.Point(31, 37);
            this.labelV1.Name = "labelV1";
            this.labelV1.Size = new System.Drawing.Size(27, 18);
            this.labelV1.TabIndex = 3;
            this.labelV1.Text = "V1";
            // 
            // labelColor
            // 
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(36, 127);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(60, 25);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Color:";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(99, 119);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(56, 41);
            this.buttonColor.TabIndex = 14;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonBColor
            // 
            this.buttonBColor.Location = new System.Drawing.Point(116, 47);
            this.buttonBColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBColor.Name = "buttonBColor";
            this.buttonBColor.Size = new System.Drawing.Size(56, 41);
            this.buttonBColor.TabIndex = 15;
            this.buttonBColor.UseVisualStyleBackColor = true;
            this.buttonBColor.Click += new System.EventHandler(this.buttonBColor_Click);
            // 
            // labelBColor
            // 
            this.labelBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBColor.Location = new System.Drawing.Point(36, 53);
            this.labelBColor.Name = "labelBColor";
            this.labelBColor.Size = new System.Drawing.Size(75, 25);
            this.labelBColor.TabIndex = 16;
            this.labelBColor.Text = "Border:";
            this.labelBColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.labelBColor);
            this.panelColor.Controls.Add(this.buttonColor);
            this.panelColor.Controls.Add(this.buttonBColor);
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColor.Location = new System.Drawing.Point(206, 0);
            this.panelColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(207, 272);
            this.panelColor.TabIndex = 17;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonOK);
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 272);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(413, 62);
            this.panelButtons.TabIndex = 18;
            // 
            // FormTriProp
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(413, 334);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelProps);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTriProp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Triangle Properties";
            this.panelProps.ResumeLayout(false);
            this.panelProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV3X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV3Y)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Panel panelProps;
        private System.Windows.Forms.NumericUpDown numericUpDownV1X;
        private System.Windows.Forms.NumericUpDown numericUpDownV1Y;
        private System.Windows.Forms.NumericUpDown numericUpDownV2X;
        private System.Windows.Forms.NumericUpDown numericUpDownV2Y;
        private System.Windows.Forms.NumericUpDown numericUpDownV3X;
        private System.Windows.Forms.NumericUpDown numericUpDownV3Y;
        private System.Windows.Forms.Label labelV3Y;
        private System.Windows.Forms.Label labelV3X;
        private System.Windows.Forms.Label labelV2Y;
        private System.Windows.Forms.Label labelV2X;
        private System.Windows.Forms.Label labelV1Y;
        private System.Windows.Forms.Label labelV1X;
        private System.Windows.Forms.Label labelV3;
        private System.Windows.Forms.Label labelV2;
        private System.Windows.Forms.Label labelV1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonBColor;
        private System.Windows.Forms.Label labelBColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelInfo;
    }
}