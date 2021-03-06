﻿namespace APO
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.posterizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicWindowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultbutton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.neighborhoodOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicWindowChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(844, 109);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(677, 555);
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
            this.thresholdingGrayLevelsToolStripMenuItem,
            this.posterizeToolStripMenuItem,
            this.neighborhoodOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1628, 28);
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
            this.saveHistogramToolStripMenuItem.Enabled = false;
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
            this.equalizationToolStripMenuItem.Enabled = false;
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // selectiveEqualizationToolStripMenuItem
            // 
            this.selectiveEqualizationToolStripMenuItem.Enabled = false;
            this.selectiveEqualizationToolStripMenuItem.Name = "selectiveEqualizationToolStripMenuItem";
            this.selectiveEqualizationToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.selectiveEqualizationToolStripMenuItem.Text = "Selective Equalization";
            this.selectiveEqualizationToolStripMenuItem.Click += new System.EventHandler(this.selectiveEqualizationToolStripMenuItem_Click);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Enabled = false;
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.stretchToolStripMenuItem_Click);
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            this.thresholdingToolStripMenuItem.Click += new System.EventHandler(this.thresholdingToolStripMenuItem_Click);
            // 
            // thresholdingGrayLevelsToolStripMenuItem
            // 
            this.thresholdingGrayLevelsToolStripMenuItem.Name = "thresholdingGrayLevelsToolStripMenuItem";
            this.thresholdingGrayLevelsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.thresholdingGrayLevelsToolStripMenuItem.Text = "Thresholding - gray levels";
            this.thresholdingGrayLevelsToolStripMenuItem.Click += new System.EventHandler(this.thresholdingGrayLevelsToolStripMenuItem_Click);
            // 
            // posterizeToolStripMenuItem
            // 
            this.posterizeToolStripMenuItem.Name = "posterizeToolStripMenuItem";
            this.posterizeToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.posterizeToolStripMenuItem.Text = "Posterize";
            this.posterizeToolStripMenuItem.Click += new System.EventHandler(this.posterizeToolStripMenuItem_Click);
            // 
            // GraphicWindowChart
            // 
            chartArea3.Name = "ChartArea1";
            this.GraphicWindowChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GraphicWindowChart.Legends.Add(legend3);
            this.GraphicWindowChart.Location = new System.Drawing.Point(27, 109);
            this.GraphicWindowChart.Name = "GraphicWindowChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.GraphicWindowChart.Series.Add(series3);
            this.GraphicWindowChart.Size = new System.Drawing.Size(778, 555);
            this.GraphicWindowChart.TabIndex = 2;
            this.GraphicWindowChart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1188, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower threshold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1188, 740);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upper threshold:";
            // 
            // defaultbutton
            // 
            this.defaultbutton.Location = new System.Drawing.Point(27, 690);
            this.defaultbutton.Name = "defaultbutton";
            this.defaultbutton.Size = new System.Drawing.Size(191, 70);
            this.defaultbutton.TabIndex = 7;
            this.defaultbutton.Text = "Default picture";
            this.defaultbutton.UseVisualStyleBackColor = true;
            this.defaultbutton.Click += new System.EventHandler(this.defaultbutton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1335, 690);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1335, 738);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown2.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1628, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // neighborhoodOperationsToolStripMenuItem
            // 
            this.neighborhoodOperationsToolStripMenuItem.Name = "neighborhoodOperationsToolStripMenuItem";
            this.neighborhoodOperationsToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.neighborhoodOperationsToolStripMenuItem.Text = "Neighborhood Operations";
            this.neighborhoodOperationsToolStripMenuItem.Click += new System.EventHandler(this.neighborhoodOperationsToolStripMenuItem_Click);
            // 
            // GraphicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 781);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.defaultbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphicWindowChart);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicWindow";
            this.Text = "GraphicWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicWindowChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button defaultbutton;
        private System.Windows.Forms.ToolStripMenuItem posterizeToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem neighborhoodOperationsToolStripMenuItem;
    }
}