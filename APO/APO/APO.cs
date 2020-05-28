using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO
{
    public partial class APO : Form
    {
        public APO()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog g = new OpenFileDialog();
            g.ShowDialog();

            try
            {
                GraphicWindow pictureWindow = new GraphicWindow(new Bitmap(g.FileName));
                pictureWindow.Show();
            }
            catch
            {
                MessageBox.Show("You have not selected anything \n You must select a picture");
            }
        }
    }
}
