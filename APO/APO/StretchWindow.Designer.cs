namespace APO
{
    partial class StretchWindow
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
            this.Stretchbutton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Applybutton = new System.Windows.Forms.Button();
            this.StretchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.StretchWindowPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StretchChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Stretchbutton
            // 
            this.Stretchbutton.Location = new System.Drawing.Point(930, 47);
            this.Stretchbutton.Name = "Stretchbutton";
            this.Stretchbutton.Size = new System.Drawing.Size(132, 72);
            this.Stretchbutton.TabIndex = 1;
            this.Stretchbutton.Text = "Stretch";
            this.Stretchbutton.UseVisualStyleBackColor = true;
            this.Stretchbutton.Click += new System.EventHandler(this.Stretchbutton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(584, 47);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 72);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Applybutton
            // 
            this.Applybutton.Location = new System.Drawing.Point(751, 47);
            this.Applybutton.Name = "Applybutton";
            this.Applybutton.Size = new System.Drawing.Size(132, 72);
            this.Applybutton.TabIndex = 3;
            this.Applybutton.Text = "Apply";
            this.Applybutton.UseVisualStyleBackColor = true;
            this.Applybutton.Click += new System.EventHandler(this.Applybutton_Click);
            // 
            // StretchChart
            // 
            chartArea3.Name = "ChartArea1";
            this.StretchChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.StretchChart.Legends.Add(legend3);
            this.StretchChart.Location = new System.Drawing.Point(773, 225);
            this.StretchChart.Name = "StretchChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.StretchChart.Series.Add(series3);
            this.StretchChart.Size = new System.Drawing.Size(436, 407);
            this.StretchChart.TabIndex = 4;
            this.StretchChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max Value";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(699, 151);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(104, 22);
            this.textBoxMin.TabIndex = 7;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(958, 151);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(104, 22);
            this.textBoxMax.TabIndex = 8;
            // 
            // StretchWindowPictureBox
            // 
            this.StretchWindowPictureBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.StretchWindowPictureBox.Location = new System.Drawing.Point(220, 208);
            this.StretchWindowPictureBox.Name = "StretchWindowPictureBox";
            this.StretchWindowPictureBox.Size = new System.Drawing.Size(455, 537);
            this.StretchWindowPictureBox.TabIndex = 9;
            this.StretchWindowPictureBox.TabStop = false;
            // 
            // StretchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 910);
            this.Controls.Add(this.StretchWindowPictureBox);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StretchChart);
            this.Controls.Add(this.Applybutton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Stretchbutton);
            this.Name = "StretchWindow";
            this.Text = "StretchWindow";
            ((System.ComponentModel.ISupportInitialize)(this.StretchChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchWindowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stretchbutton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Applybutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart StretchChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.PictureBox StretchWindowPictureBox;
    }
}