namespace APO
{
    partial class MorphologicalWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.ErodeButton = new System.Windows.Forms.Button();
            this.DilateButton = new System.Windows.Forms.Button();
            this.OpeningButton = new System.Windows.Forms.Button();
            this.ClosingButton = new System.Windows.Forms.Button();
            this.DiamondRadioButton = new System.Windows.Forms.RadioButton();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NxMGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButton3X3 = new System.Windows.Forms.RadioButton();
            this.RadioButton5X5 = new System.Windows.Forms.RadioButton();
            this.RadioButton7X7 = new System.Windows.Forms.RadioButton();
            this.MorfologicalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SkeletonButton = new System.Windows.Forms.Button();
            this.MorfologicalPictureBox = new System.Windows.Forms.PictureBox();
            this.IsolatedRadioButton = new System.Windows.Forms.RadioButton();
            this.ReflectRadioButton = new System.Windows.Forms.RadioButton();
            this.ReplicateRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.NxMGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErodeButton
            // 
            this.ErodeButton.Enabled = false;
            this.ErodeButton.Location = new System.Drawing.Point(28, 18);
            this.ErodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ErodeButton.Name = "ErodeButton";
            this.ErodeButton.Size = new System.Drawing.Size(192, 48);
            this.ErodeButton.TabIndex = 1;
            this.ErodeButton.Text = "Erode";
            this.ErodeButton.UseVisualStyleBackColor = true;
            this.ErodeButton.Click += new System.EventHandler(this.ErodeButton_Click);
            // 
            // DilateButton
            // 
            this.DilateButton.Enabled = false;
            this.DilateButton.Location = new System.Drawing.Point(28, 74);
            this.DilateButton.Margin = new System.Windows.Forms.Padding(4);
            this.DilateButton.Name = "DilateButton";
            this.DilateButton.Size = new System.Drawing.Size(192, 48);
            this.DilateButton.TabIndex = 2;
            this.DilateButton.Text = "Dilate";
            this.DilateButton.UseVisualStyleBackColor = true;
            this.DilateButton.Click += new System.EventHandler(this.DilateButton_Click);
            // 
            // OpeningButton
            // 
            this.OpeningButton.Enabled = false;
            this.OpeningButton.Location = new System.Drawing.Point(28, 129);
            this.OpeningButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpeningButton.Name = "OpeningButton";
            this.OpeningButton.Size = new System.Drawing.Size(192, 48);
            this.OpeningButton.TabIndex = 3;
            this.OpeningButton.Text = "Opening";
            this.OpeningButton.UseVisualStyleBackColor = true;
            this.OpeningButton.Click += new System.EventHandler(this.OpeningButton_Click);
            // 
            // ClosingButton
            // 
            this.ClosingButton.Enabled = false;
            this.ClosingButton.Location = new System.Drawing.Point(28, 185);
            this.ClosingButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClosingButton.Name = "ClosingButton";
            this.ClosingButton.Size = new System.Drawing.Size(192, 48);
            this.ClosingButton.TabIndex = 4;
            this.ClosingButton.Text = "Closing";
            this.ClosingButton.UseVisualStyleBackColor = true;
            this.ClosingButton.Click += new System.EventHandler(this.ClosingButton_Click);
            // 
            // DiamondRadioButton
            // 
            this.DiamondRadioButton.AutoSize = true;
            this.DiamondRadioButton.Location = new System.Drawing.Point(28, 258);
            this.DiamondRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DiamondRadioButton.Name = "DiamondRadioButton";
            this.DiamondRadioButton.Size = new System.Drawing.Size(83, 21);
            this.DiamondRadioButton.TabIndex = 5;
            this.DiamondRadioButton.TabStop = true;
            this.DiamondRadioButton.Text = "diamond";
            this.DiamondRadioButton.UseVisualStyleBackColor = true;
            this.DiamondRadioButton.CheckedChanged += new System.EventHandler(this.DiamondRadioButton_CheckedChanged);
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.AutoSize = true;
            this.SquareRadioButton.Checked = true;
            this.SquareRadioButton.Location = new System.Drawing.Point(144, 258);
            this.SquareRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(73, 21);
            this.SquareRadioButton.TabIndex = 6;
            this.SquareRadioButton.TabStop = true;
            this.SquareRadioButton.Text = "square";
            this.SquareRadioButton.UseVisualStyleBackColor = true;
            this.SquareRadioButton.CheckedChanged += new System.EventHandler(this.SquareRadioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.savePictureToolStripMenuItem,
            this.saveHistogramToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1696, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // savePictureToolStripMenuItem
            // 
            this.savePictureToolStripMenuItem.Enabled = false;
            this.savePictureToolStripMenuItem.Name = "savePictureToolStripMenuItem";
            this.savePictureToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.savePictureToolStripMenuItem.Text = "Save picture";
            this.savePictureToolStripMenuItem.Click += new System.EventHandler(this.savePictureToolStripMenuItem_Click);
            // 
            // saveHistogramToolStripMenuItem
            // 
            this.saveHistogramToolStripMenuItem.Enabled = false;
            this.saveHistogramToolStripMenuItem.Name = "saveHistogramToolStripMenuItem";
            this.saveHistogramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.saveHistogramToolStripMenuItem.Text = "Save histogram";
            this.saveHistogramToolStripMenuItem.Click += new System.EventHandler(this.saveHistogramToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Enabled = false;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NxMGroupBox);
            this.groupBox1.Controls.Add(this.SquareRadioButton);
            this.groupBox1.Controls.Add(this.DiamondRadioButton);
            this.groupBox1.Controls.Add(this.ClosingButton);
            this.groupBox1.Controls.Add(this.OpeningButton);
            this.groupBox1.Controls.Add(this.DilateButton);
            this.groupBox1.Controls.Add(this.ErodeButton);
            this.groupBox1.Location = new System.Drawing.Point(1448, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(248, 380);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // NxMGroupBox
            // 
            this.NxMGroupBox.Controls.Add(this.RadioButton3X3);
            this.NxMGroupBox.Controls.Add(this.RadioButton5X5);
            this.NxMGroupBox.Controls.Add(this.RadioButton7X7);
            this.NxMGroupBox.Location = new System.Drawing.Point(28, 287);
            this.NxMGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.NxMGroupBox.Name = "NxMGroupBox";
            this.NxMGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.NxMGroupBox.Size = new System.Drawing.Size(192, 64);
            this.NxMGroupBox.TabIndex = 70;
            this.NxMGroupBox.TabStop = false;
            // 
            // RadioButton3X3
            // 
            this.RadioButton3X3.AutoSize = true;
            this.RadioButton3X3.Checked = true;
            this.RadioButton3X3.Location = new System.Drawing.Point(8, 23);
            this.RadioButton3X3.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton3X3.Name = "RadioButton3X3";
            this.RadioButton3X3.Size = new System.Drawing.Size(51, 21);
            this.RadioButton3X3.TabIndex = 49;
            this.RadioButton3X3.TabStop = true;
            this.RadioButton3X3.Text = "3x3";
            this.RadioButton3X3.UseVisualStyleBackColor = true;
            this.RadioButton3X3.CheckedChanged += new System.EventHandler(this.RadioButton3X3_CheckedChanged);
            // 
            // RadioButton5X5
            // 
            this.RadioButton5X5.AutoSize = true;
            this.RadioButton5X5.Location = new System.Drawing.Point(64, 23);
            this.RadioButton5X5.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton5X5.Name = "RadioButton5X5";
            this.RadioButton5X5.Size = new System.Drawing.Size(51, 21);
            this.RadioButton5X5.TabIndex = 50;
            this.RadioButton5X5.Text = "5x5";
            this.RadioButton5X5.UseVisualStyleBackColor = true;
            this.RadioButton5X5.CheckedChanged += new System.EventHandler(this.RadioButton5X5_CheckedChanged);
            // 
            // RadioButton7X7
            // 
            this.RadioButton7X7.AutoSize = true;
            this.RadioButton7X7.Location = new System.Drawing.Point(128, 23);
            this.RadioButton7X7.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton7X7.Name = "RadioButton7X7";
            this.RadioButton7X7.Size = new System.Drawing.Size(51, 21);
            this.RadioButton7X7.TabIndex = 51;
            this.RadioButton7X7.Text = "7x7";
            this.RadioButton7X7.UseVisualStyleBackColor = true;
            this.RadioButton7X7.CheckedChanged += new System.EventHandler(this.RadioButton7X7_CheckedChanged);
            // 
            // MorfologicalChart
            // 
            this.MorfologicalChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.MorfologicalChart.ChartAreas.Add(chartArea3);
            this.MorfologicalChart.Location = new System.Drawing.Point(193, 35);
            this.MorfologicalChart.Margin = new System.Windows.Forms.Padding(4);
            this.MorfologicalChart.Name = "MorfologicalChart";
            this.MorfologicalChart.Size = new System.Drawing.Size(555, 380);
            this.MorfologicalChart.TabIndex = 70;
            this.MorfologicalChart.Text = "chart1";
            // 
            // SkeletonButton
            // 
            this.SkeletonButton.Enabled = false;
            this.SkeletonButton.Location = new System.Drawing.Point(16, 44);
            this.SkeletonButton.Margin = new System.Windows.Forms.Padding(4);
            this.SkeletonButton.Name = "SkeletonButton";
            this.SkeletonButton.Size = new System.Drawing.Size(169, 48);
            this.SkeletonButton.TabIndex = 71;
            this.SkeletonButton.Text = "Skeleton";
            this.SkeletonButton.UseVisualStyleBackColor = true;
            this.SkeletonButton.Click += new System.EventHandler(this.SkeletonButton_Click);
            // 
            // MorfologicalPictureBox
            // 
            this.MorfologicalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MorfologicalPictureBox.Location = new System.Drawing.Point(756, 35);
            this.MorfologicalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MorfologicalPictureBox.Name = "MorfologicalPictureBox";
            this.MorfologicalPictureBox.Size = new System.Drawing.Size(668, 380);
            this.MorfologicalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MorfologicalPictureBox.TabIndex = 0;
            this.MorfologicalPictureBox.TabStop = false;
            // 
            // IsolatedRadioButton
            // 
            this.IsolatedRadioButton.AutoSize = true;
            this.IsolatedRadioButton.Location = new System.Drawing.Point(13, 25);
            this.IsolatedRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.IsolatedRadioButton.Name = "IsolatedRadioButton";
            this.IsolatedRadioButton.Size = new System.Drawing.Size(78, 21);
            this.IsolatedRadioButton.TabIndex = 0;
            this.IsolatedRadioButton.TabStop = true;
            this.IsolatedRadioButton.Text = "Isolated";
            this.IsolatedRadioButton.UseVisualStyleBackColor = true;
            this.IsolatedRadioButton.CheckedChanged += new System.EventHandler(this.IsolatedRadioButton_CheckedChanged);
            // 
            // ReflectRadioButton
            // 
            this.ReflectRadioButton.AutoSize = true;
            this.ReflectRadioButton.Location = new System.Drawing.Point(13, 49);
            this.ReflectRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReflectRadioButton.Name = "ReflectRadioButton";
            this.ReflectRadioButton.Size = new System.Drawing.Size(73, 21);
            this.ReflectRadioButton.TabIndex = 1;
            this.ReflectRadioButton.TabStop = true;
            this.ReflectRadioButton.Text = "Reflect";
            this.ReflectRadioButton.UseVisualStyleBackColor = true;
            this.ReflectRadioButton.CheckedChanged += new System.EventHandler(this.ReflectRadioButton_CheckedChanged);
            // 
            // ReplicateRadioButton
            // 
            this.ReplicateRadioButton.AutoSize = true;
            this.ReplicateRadioButton.Location = new System.Drawing.Point(13, 73);
            this.ReplicateRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReplicateRadioButton.Name = "ReplicateRadioButton";
            this.ReplicateRadioButton.Size = new System.Drawing.Size(88, 21);
            this.ReplicateRadioButton.TabIndex = 2;
            this.ReplicateRadioButton.TabStop = true;
            this.ReplicateRadioButton.Text = "Replicate";
            this.ReplicateRadioButton.UseVisualStyleBackColor = true;
            this.ReplicateRadioButton.CheckedChanged += new System.EventHandler(this.ReplicateRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReplicateRadioButton);
            this.groupBox2.Controls.Add(this.ReflectRadioButton);
            this.groupBox2.Controls.Add(this.IsolatedRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 305);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(169, 110);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Pixel Values";
            // 
            // MorphologicalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 428);
            this.Controls.Add(this.SkeletonButton);
            this.Controls.Add(this.MorfologicalChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MorfologicalPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MorphologicalWindow";
            this.Text = "MorphologicalOperationsForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.NxMGroupBox.ResumeLayout(false);
            this.NxMGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorfologicalPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MorfologicalPictureBox;
        private System.Windows.Forms.Button ErodeButton;
        private System.Windows.Forms.Button DilateButton;
        private System.Windows.Forms.Button OpeningButton;
        private System.Windows.Forms.Button ClosingButton;
        private System.Windows.Forms.RadioButton DiamondRadioButton;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox NxMGroupBox;
        private System.Windows.Forms.RadioButton RadioButton3X3;
        private System.Windows.Forms.RadioButton RadioButton5X5;
        private System.Windows.Forms.RadioButton RadioButton7X7;
        private System.Windows.Forms.DataVisualization.Charting.Chart MorfologicalChart;
        private System.Windows.Forms.Button SkeletonButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.RadioButton IsolatedRadioButton;
        private System.Windows.Forms.RadioButton ReflectRadioButton;
        private System.Windows.Forms.RadioButton ReplicateRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}