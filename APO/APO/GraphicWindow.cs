using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    public partial class GraphicWindow : Form
    {

        public Bitmap bitmap { get; set; }
        public Chart chart { get; set; }
        public bool Gray { get; set; }
        public bool RGB { get; set; }
        
        
        public GraphicWindow(Bitmap picture)
        {
            InitializeComponent();

            PictureBox.Image = picture;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.bitmap = bitmap;
            Gray = false;
            RGB = false;
        }
    }
}
