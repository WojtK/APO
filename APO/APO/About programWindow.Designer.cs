﻿namespace APO
{
    partial class About_programWindow
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ReturnButton.Location = new System.Drawing.Point(127, 241);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(216, 57);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "OK";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 125);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplikacja zbiorcza z ćwiczeń laboratoryjnych\r\nAutor: Kucharek Wojciech\r\nProwadząc" +
    "y: mgr inż. Łukasz Roszkowiak\r\nAlgorytmy Przetwarzania Obrazów 2020\r\nWIT grupa I" +
    "D: IO2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 0;
            // 
            // About_programWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(486, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "About_programWindow";
            this.Text = "About program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}