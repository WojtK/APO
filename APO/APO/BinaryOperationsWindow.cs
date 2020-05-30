using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    public partial class BinaryOperationsWindow : Form
    {

        private Image<Bgra, byte> PictureA;
        private Image<Bgra, byte> PictureB;
        public BinaryOperationsWindow()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                pictureBoxA.Image = new Bitmap(dialog.FileName);
                Bitmap bitmapA = (Bitmap)pictureBoxA.Image;
                pictureBoxA.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxA.SizeMode = PictureBoxSizeMode.StretchImage;
             //   this.PictureA = bitmapA.ToImage<Bgra, byte>();
                Histogram_PictureA();
                chartA.Visible = true;
            }
            catch
            {
                MessageBox.Show("You have not selected anything \nYou must select a picture");
            }
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                pictureBoxB.Image = new Bitmap(dialog.FileName);
                Bitmap bitmapB = (Bitmap)pictureBoxB.Image;
                pictureBoxB.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxB.SizeMode = PictureBoxSizeMode.StretchImage;
              //  this.PictureB = bitmapB.ToImage<Bgra, byte>();
                Histogram_PictureB();
                chartB.Visible = true;
            }
            catch
            {
                MessageBox.Show("You have not selected anything \nYou must select a picture");
            }
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pic = new SaveFileDialog();
            pic.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            pic.FileName = "Image";
            pic.ShowDialog();

            try { this.ResultPictureBox.Image.Save(pic.FileName); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }

            Image<Bgra, byte> resultImage = new Image<Bgra, byte>(ResultPictureBox.Size.Width, ResultPictureBox.Size.Height);
                Image<Bgra, byte> imageBresized = new Image<Bgra, byte>(PictureA.Size.Width, PictureA.Size.Height);
                CvInvoke.Resize(PictureB, imageBresized, PictureA.Size);
                resultImage = PictureA.Add(imageBresized, null);
              //  ResultPictureBox.Image = resultImage.ToBitmap();
                Histogram_ResultPicture();
                chartResult.Visible = true;
                saveResultToolStripMenuItem.Enabled = true;
                return;
        }

        private void blendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }


            chartResult.Visible = true;
            saveResultToolStripMenuItem.Enabled = true;
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }




            chartResult.Visible = true;
            saveResultToolStripMenuItem.Enabled = true;
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }


            chartResult.Visible = true;
            saveResultToolStripMenuItem.Enabled = true;
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }


            chartResult.Visible = true;
            saveResultToolStripMenuItem.Enabled = true;
        }

        private void nOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxA.Image == null)
            {
                MessageBox.Show("Select picture A.");
                return;
            }
            if (pictureBoxB.Image == null)
            {
                MessageBox.Show("Select picture B.");
                return;
            }

            pictureBoxA.Image = Utility.Negation((Bitmap)pictureBoxA.Image);
            pictureBoxB.Image = Utility.Negation((Bitmap)pictureBoxB.Image);
        }

        private void Histogram_ResultPicture()
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)ResultPictureBox.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            chartResult.Series.Clear();
            chartResult.Series.Add("Red");
            chartResult.Series.Add("Blue");
            chartResult.Series.Add("Green");
            chartResult.Series["Red"].Color = Color.Red;
            chartResult.Series["Blue"].Color = Color.Blue;
            chartResult.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.chartResult.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.chartResult.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.chartResult.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
        private void Histogram_PictureA()
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)pictureBoxA.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            chartA.Series.Clear();
            chartA.Series.Add("Red");
            chartA.Series.Add("Blue");
            chartA.Series.Add("Green");
            chartA.Series["Red"].Color = Color.Red;
            chartA.Series["Blue"].Color = Color.Blue;
            chartA.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.chartA.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.chartA.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.chartA.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
        private void Histogram_PictureB()
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)pictureBoxB.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            chartB.Series.Clear();
            chartB.Series.Add("Red");
            chartB.Series.Add("Blue");
            chartB.Series.Add("Green");
            chartB.Series["Red"].Color = Color.Red;
            chartB.Series["Blue"].Color = Color.Blue;
            chartB.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.chartB.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.chartB.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.chartB.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
        }
    }
}
