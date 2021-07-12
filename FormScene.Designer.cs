
namespace OOPCourseProject
{
    partial class FormScene
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMouseX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMouseY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelDrawInfo = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMode = new System.Windows.Forms.Label();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.buttonCircle);
            this.panelButtons.Controls.Add(this.buttonTriangle);
            this.panelButtons.Controls.Add(this.buttonRectangle);
            this.panelButtons.Location = new System.Drawing.Point(818, 504);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(10);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(128, 150);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCircle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCircle.Location = new System.Drawing.Point(0, 100);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(128, 50);
            this.buttonCircle.TabIndex = 10;
            this.buttonCircle.TabStop = false;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTriangle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.Location = new System.Drawing.Point(0, 50);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(128, 50);
            this.buttonTriangle.TabIndex = 9;
            this.buttonTriangle.TabStop = false;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRectangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRectangle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRectangle.Location = new System.Drawing.Point(0, 0);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(128, 50);
            this.buttonRectangle.TabIndex = 8;
            this.buttonRectangle.TabStop = false;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelArea,
            this.toolStripStatusLabelMousePos,
            this.toolStripStatusLabelMouseX,
            this.toolStripStatusLabelMouseY,
            this.toolStripStatusLabelHelp});
            this.statusStrip.Location = new System.Drawing.Point(0, 654);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(946, 26);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabelArea
            // 
            this.toolStripStatusLabelArea.Margin = new System.Windows.Forms.Padding(0, 4, 10, 2);
            this.toolStripStatusLabelArea.Name = "toolStripStatusLabelArea";
            this.toolStripStatusLabelArea.Size = new System.Drawing.Size(174, 20);
            this.toolStripStatusLabelArea.Text = "toolStripStatusLabelArea";
            // 
            // toolStripStatusLabelMousePos
            // 
            this.toolStripStatusLabelMousePos.Name = "toolStripStatusLabelMousePos";
            this.toolStripStatusLabelMousePos.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabelMousePos.Text = "Cursor Pos.";
            this.toolStripStatusLabelMousePos.ToolTipText = "Cursor position:";
            // 
            // toolStripStatusLabelMouseX
            // 
            this.toolStripStatusLabelMouseX.Margin = new System.Windows.Forms.Padding(0, 4, 4, 2);
            this.toolStripStatusLabelMouseX.Name = "toolStripStatusLabelMouseX";
            this.toolStripStatusLabelMouseX.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabelMouseY
            // 
            this.toolStripStatusLabelMouseY.Name = "toolStripStatusLabelMouseY";
            this.toolStripStatusLabelMouseY.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabelHelp
            // 
            this.toolStripStatusLabelHelp.Name = "toolStripStatusLabelHelp";
            this.toolStripStatusLabelHelp.Size = new System.Drawing.Size(663, 20);
            this.toolStripStatusLabelHelp.Spring = true;
            this.toolStripStatusLabelHelp.Text = "Press H for Help.";
            this.toolStripStatusLabelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColor.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Location = new System.Drawing.Point(11, 27);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(64, 50);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.TabStop = false;
            this.buttonColor.Text = "No Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.Transparent;
            this.panelColor.Controls.Add(this.labelColor);
            this.panelColor.Controls.Add(this.buttonColor);
            this.panelColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelColor.Location = new System.Drawing.Point(730, 577);
            this.panelColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(88, 77);
            this.panelColor.TabIndex = 4;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(-4, 6);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(114, 21);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Selected Color:";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDrawInfo
            // 
            this.labelDrawInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrawInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelDrawInfo.Location = new System.Drawing.Point(791, 28);
            this.labelDrawInfo.Name = "labelDrawInfo";
            this.labelDrawInfo.Size = new System.Drawing.Size(155, 43);
            this.labelDrawInfo.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(946, 28);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSceneToolStripMenuItem,
            this.toolStripMenuItemOpen,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.Transparent;
            this.labelMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(11, 626);
            this.labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(137, 22);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "Mode: Rectangle";
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            this.newSceneToolStripMenuItem.Click += new System.EventHandler(this.newSceneToolStripMenuItem_Click);
            // 
            // FormScene
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 680);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelDrawInfo);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(650, 515);
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.panelButtons.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArea;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMouseX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMouseY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMousePos;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelDrawInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
    }
}

