namespace APO
{
    partial class APO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborhoodOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfologicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.binaryOperationsToolStripMenuItem,
            this.neighborhoodOperationsToolStripMenuItem,
            this.morfologicalToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // binaryOperationsToolStripMenuItem
            // 
            this.binaryOperationsToolStripMenuItem.Name = "binaryOperationsToolStripMenuItem";
            this.binaryOperationsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.binaryOperationsToolStripMenuItem.Text = "Binary Operations";
            this.binaryOperationsToolStripMenuItem.Click += new System.EventHandler(this.binaryOperationsToolStripMenuItem_Click);
            // 
            // neighborhoodOperationsToolStripMenuItem
            // 
            this.neighborhoodOperationsToolStripMenuItem.Name = "neighborhoodOperationsToolStripMenuItem";
            this.neighborhoodOperationsToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.neighborhoodOperationsToolStripMenuItem.Text = "Neighborhood Operations";
            this.neighborhoodOperationsToolStripMenuItem.Click += new System.EventHandler(this.neighborhoodOperationsToolStripMenuItem_Click);
            // 
            // morfologicalToolStripMenuItem
            // 
            this.morfologicalToolStripMenuItem.Name = "morfologicalToolStripMenuItem";
            this.morfologicalToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.morfologicalToolStripMenuItem.Text = "Morfological";
            this.morfologicalToolStripMenuItem.Click += new System.EventHandler(this.morfologicalToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click_1);
            // 
            // APO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 702);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "APO";
            this.Text = "APO by kucharek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborhoodOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfologicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}