namespace APO
{
    partial class PosterizeWindow
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
            this.PosterizeWindowPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxColors = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PosterizeButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PosterizeWindowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PosterizeWindowPicture
            // 
            this.PosterizeWindowPicture.Location = new System.Drawing.Point(569, 66);
            this.PosterizeWindowPicture.Name = "PosterizeWindowPicture";
            this.PosterizeWindowPicture.Size = new System.Drawing.Size(468, 530);
            this.PosterizeWindowPicture.TabIndex = 0;
            this.PosterizeWindowPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Min 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Max 255";
            // 
            // textboxColors
            // 
            this.textboxColors.Location = new System.Drawing.Point(192, 122);
            this.textboxColors.Name = "textboxColors";
            this.textboxColors.Size = new System.Drawing.Size(103, 22);
            this.textboxColors.TabIndex = 14;
            this.textboxColors.Text = "100";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(50, 204);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 72);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PosterizeButton
            // 
            this.PosterizeButton.Location = new System.Drawing.Point(214, 204);
            this.PosterizeButton.Name = "PosterizeButton";
            this.PosterizeButton.Size = new System.Drawing.Size(132, 72);
            this.PosterizeButton.TabIndex = 16;
            this.PosterizeButton.Text = "Posterize";
            this.PosterizeButton.UseVisualStyleBackColor = true;
            this.PosterizeButton.Click += new System.EventHandler(this.PosterizeButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(385, 204);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(132, 72);
            this.ApplyButton.TabIndex = 17;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // PosterizeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 641);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.PosterizeButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.textboxColors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosterizeWindowPicture);
            this.Name = "PosterizeWindow";
            this.Text = "PosterizeWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PosterizeWindowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterizeWindowPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxColors;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PosterizeButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}