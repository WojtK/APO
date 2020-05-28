namespace APO
{
    partial class GraphicWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cloneWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveEqualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingGrayLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicWindowChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(841, 45);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(574, 555);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cloneWindowToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.saveHistogramToolStripMenuItem,
            this.savePictureToolStripMenuItem,
            this.negationToolStripMenuItem,
            this.equalizationToolStripMenuItem,
            this.selectiveEqualizationToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.thresholdingToolStripMenuItem,
            this.thresholdingGrayLevelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cloneWindowToolStripMenuItem
            // 
            this.cloneWindowToolStripMenuItem.Name = "cloneWindowToolStripMenuItem";
            this.cloneWindowToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.cloneWindowToolStripMenuItem.Text = "Clone Window";
            this.cloneWindowToolStripMenuItem.Click += new System.EventHandler(this.cloneWindowToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.rGBToolStripMenuItem.Text = "RGB";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click_1);
            // 
            // saveHistogramToolStripMenuItem
            // 
            this.saveHistogramToolStripMenuItem.Name = "saveHistogramToolStripMenuItem";
            this.saveHistogramToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.saveHistogramToolStripMenuItem.Text = "Save Histogram";
            this.saveHistogramToolStripMenuItem.Click += new System.EventHandler(this.saveHistogramToolStripMenuItem_Click_1);
            // 
            // savePictureToolStripMenuItem
            // 
            this.savePictureToolStripMenuItem.Name = "savePictureToolStripMenuItem";
            this.savePictureToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.savePictureToolStripMenuItem.Text = "Save Picture";
            this.savePictureToolStripMenuItem.Click += new System.EventHandler(this.savePictureToolStripMenuItem_Click);
            // 
            // negationToolStripMenuItem
            // 
            this.negationToolStripMenuItem.Name = "negationToolStripMenuItem";
            this.negationToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.negationToolStripMenuItem.Text = "Negation";
            this.negationToolStripMenuItem.Click += new System.EventHandler(this.negationToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // selectiveEqualizationToolStripMenuItem
            // 
            this.selectiveEqualizationToolStripMenuItem.Name = "selectiveEqualizationToolStripMenuItem";
            this.selectiveEqualizationToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.selectiveEqualizationToolStripMenuItem.Text = "Selective Equalization";
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.stretchToolStripMenuItem.Text = "Stretch";
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            // 
            // thresholdingGrayLevelsToolStripMenuItem
            // 
            this.thresholdingGrayLevelsToolStripMenuItem.Name = "thresholdingGrayLevelsToolStripMenuItem";
            this.thresholdingGrayLevelsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.thresholdingGrayLevelsToolStripMenuItem.Text = "Thresholding - gray levels";
            // 
            // GraphicWindowChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphicWindowChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphicWindowChart.Legends.Add(legend1);
            this.GraphicWindowChart.Location = new System.Drawing.Point(27, 45);
            this.GraphicWindowChart.Name = "GraphicWindowChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraphicWindowChart.Series.Add(series1);
            this.GraphicWindowChart.Size = new System.Drawing.Size(778, 555);
            this.GraphicWindowChart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "P1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GraphicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphicWindowChart);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicWindow";
            this.Text = "P1:";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicWindowChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cloneWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHistogramToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphicWindowChart;
        private System.Windows.Forms.ToolStripMenuItem savePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveEqualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingGrayLevelsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}