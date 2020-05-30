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
using System.Windows.Forms.DataVisualization.Charting;

namespace APO
{
    public partial class NeighborhoodOperationsWindow : Form
    {

        public Image<Bgra, byte> picture;
        private Image<Bgra, byte> inputPicture;
        public bool fromPictureWindow;
        public NeighborhoodOperationsWindow()
        {
            InitializeComponent();
        }

        public NeighborhoodOperationsWindow(Image<Bgra, byte> image)
        {
            InitializeComponent();
            this.picture = image;
            this.inputPicture = image;
            NeighborhoodPicture.Image = image.ToBitmap();
            Histogram();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picture = new Image<Bgra, byte>(dialog.FileName);
                inputPicture = picture;
                NeighborhoodPicture.Image = picture.ToBitmap();
                Histogram();
                NeighborhoodChart.Visible = true;
                saveHistogramToolStripMenuItem.Enabled = true;
                resetToolStripMenuItem.Enabled = true;
                savePictureToolStripMenuItem.Enabled = true;
            }
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { NeighborhoodPicture.Image.Save(x.FileName); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeighborhoodPicture.Image = inputPicture.ToBitmap();
            Histogram();
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicWindow window = new GraphicWindow((Bitmap)NeighborhoodPicture.Image);
            window.Show();
            this.Close();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                Image<Bgra, byte> dst = new Image<Bgra, byte>(NeighborhoodPicture.Size.Width, NeighborhoodPicture.Size.Height);
                dst = picture.SmoothGaussian(13);
                NeighborhoodPicture.Image = dst.ToBitmap();
                Histogram();
            }
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Histogram()
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)NeighborhoodPicture.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            NeighborhoodChart.Series.Clear();
            NeighborhoodChart.Series.Add("Red");
            NeighborhoodChart.Series.Add("Blue");
            NeighborhoodChart.Series.Add("Green");
            NeighborhoodChart.Series["Red"].Color = Color.Red;
            NeighborhoodChart.Series["Blue"].Color = Color.Blue;
            NeighborhoodChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.NeighborhoodChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.NeighborhoodChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.NeighborhoodChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);

            }
            NeighborhoodChart.Enabled = true;
        }

        private void saveHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            save.FileName = "Histogram";
            save.ShowDialog();

            try { this.NeighborhoodChart.SaveImage(save.FileName, ChartImageFormat.Jpeg); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
