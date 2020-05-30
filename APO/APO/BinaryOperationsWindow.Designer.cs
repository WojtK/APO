namespace APO
{
    partial class BinaryOperationsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binaryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryOperationsToolStripMenuItem,
            this.saveResultToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1656, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binaryOperationsToolStripMenuItem
            // 
            this.binaryOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.blendToolStripMenuItem,
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.xORToolStripMenuItem,
            this.nOTToolStripMenuItem});
            this.binaryOperationsToolStripMenuItem.Name = "binaryOperationsToolStripMenuItem";
            this.binaryOperationsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.binaryOperationsToolStripMenuItem.Text = "Binary Operations";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // blendToolStripMenuItem
            // 
            this.blendToolStripMenuItem.Name = "blendToolStripMenuItem";
            this.blendToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.blendToolStripMenuItem.Text = "Blend";
            this.blendToolStripMenuItem.Click += new System.EventHandler(this.blendToolStripMenuItem_Click);
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.aNDToolStripMenuItem.Text = "AND";
            this.aNDToolStripMenuItem.Click += new System.EventHandler(this.aNDToolStripMenuItem_Click);
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.oRToolStripMenuItem.Text = "OR";
            this.oRToolStripMenuItem.Click += new System.EventHandler(this.oRToolStripMenuItem_Click);
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.xORToolStripMenuItem.Text = "XOR";
            this.xORToolStripMenuItem.Click += new System.EventHandler(this.xORToolStripMenuItem_Click);
            // 
            // nOTToolStripMenuItem
            // 
            this.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem";
            this.nOTToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.nOTToolStripMenuItem.Text = "NOT";
            this.nOTToolStripMenuItem.Click += new System.EventHandler(this.nOTToolStripMenuItem_Click);
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Enabled = false;
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.saveResultToolStripMenuItem.Text = "Save Result";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Location = new System.Drawing.Point(574, 74);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(393, 306);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxA.TabIndex = 1;
            this.pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(574, 433);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(393, 306);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxB.TabIndex = 2;
            this.pictureBoxB.TabStop = false;
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Location = new System.Drawing.Point(1044, 74);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(525, 353);
            this.ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultPictureBox.TabIndex = 3;
            this.ResultPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1266, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            this.label3.Visible = false;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(665, 37);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(202, 30);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "Select picture A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(665, 397);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(202, 30);
            this.buttonB.TabIndex = 8;
            this.buttonB.Text = "Select picture B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // chartA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartA.Legends.Add(legend1);
            this.chartA.Location = new System.Drawing.Point(34, 74);
            this.chartA.Name = "chartA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartA.Series.Add(series1);
            this.chartA.Size = new System.Drawing.Size(478, 306);
            this.chartA.TabIndex = 9;
            this.chartA.Text = "chart1";
            this.chartA.Visible = false;
            // 
            // chartB
            // 
            chartArea2.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartB.Legends.Add(legend2);
            this.chartB.Location = new System.Drawing.Point(34, 433);
            this.chartB.Name = "chartB";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartB.Series.Add(series2);
            this.chartB.Size = new System.Drawing.Size(478, 306);
            this.chartB.TabIndex = 10;
            this.chartB.Text = "chart2";
            this.chartB.Visible = false;
            // 
            // chartResult
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartResult.Legends.Add(legend3);
            this.chartResult.Location = new System.Drawing.Point(1044, 449);
            this.chartResult.Name = "chartResult";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult.Series.Add(series3);
            this.chartResult.Size = new System.Drawing.Size(525, 290);
            this.chartResult.TabIndex = 11;
            this.chartResult.Text = "chart3";
            this.chartResult.Visible = false;
            // 
            // BinaryOperationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 803);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.chartA);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultPictureBox);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BinaryOperationsWindow";
            this.Text = "BinaryOperationsWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binaryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
    }
}