using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class SharpeningWindow : Form
    {
        public Image<Bgra, byte> picture;
        private Image<Bgra, byte> inputPicture;
        public bool fromPictureWindow;
        Image<Bgra, byte> copy;
        public SharpeningWindow()
        {
            InitializeComponent();
        }

        public SharpeningWindow(Image<Bgra, byte> imageSh, Image<Bgra, byte> copy)
        {
            InitializeComponent();
            this.picture = imageSh;
            this.inputPicture = imageSh;
            this.copy = copy;
            PosterizeWindowPicture.Image = imageSh.ToBitmap();
            PosterizeWindowPicture.Visible = true;
            PosterizeWindowPicture.Show();

        }

        private void PosterizeButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                float[,] k = { {0, -1, 0},
                        {-1, 4,-1},
                        {0, -1, 0}};
                PosterizeWindowPicture.Image = Utility.Filter2D((Bitmap)PosterizeWindowPicture.Image, k);
            }
            else if (checkBox2.Checked)
            {
                float[,] k = { {-1, -1, -1},
                        {-1, 8,-1},
                        {-1, -1, -1}};
                PosterizeWindowPicture.Image = Utility.Filter2D((Bitmap)PosterizeWindowPicture.Image, k);

            }
            else if (checkBox3.Checked)
            {
                float[,] k = { {1, -2, 1},
                        {-2, 4,-2},
                        {1, -2, 1}};
                PosterizeWindowPicture.Image = Utility.Filter2D((Bitmap)PosterizeWindowPicture.Image, k);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
           
           NeighborhoodOperationsWindow windows = new NeighborhoodOperationsWindow((Bitmap)PosterizeWindowPicture.Image, copy);
           windows.Show();
           this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PosterizeWindowPicture.Image = this.picture.ToBitmap();
        }
    }
    }

