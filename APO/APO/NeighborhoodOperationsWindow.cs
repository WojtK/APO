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
            NeighborhoodChart.Visible = true;
            resetToolStripMenuItem.Enabled = true;
            saveHistogramToolStripMenuItem.Enabled = true;
            savePictureToolStripMenuItem.Enabled = true;
            doneToolStripMenuItem.Enabled = true;
            blurToolStripMenuItem.Enabled = true;
            medianFilterToolStripMenuItem.Enabled = true;
            edgeDetectionToolStripMenuItem.Enabled = true;
            sharpeningToolStripMenuItem.Enabled = true;
            Histogram();

        }

        public NeighborhoodOperationsWindow(Bitmap picture, Image<Bgra, byte> copy)
        {
            InitializeComponent();

            NeighborhoodPicture.Image = picture;
            this.inputPicture = copy;
            NeighborhoodPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            NeighborhoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            resetToolStripMenuItem.Enabled = true;
            NeighborhoodChart.Visible = true;
            saveHistogramToolStripMenuItem.Enabled = true;
            savePictureToolStripMenuItem.Enabled = true;
            doneToolStripMenuItem.Enabled = true;
            blurToolStripMenuItem.Enabled = true;
            medianFilterToolStripMenuItem.Enabled = true;
            edgeDetectionToolStripMenuItem.Enabled = true;
            sharpeningToolStripMenuItem.Enabled = true;


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
                doneToolStripMenuItem.Enabled = true;
                blurToolStripMenuItem.Enabled = true;
                medianFilterToolStripMenuItem.Enabled = true;
                edgeDetectionToolStripMenuItem.Enabled = true;
                sharpeningToolStripMenuItem.Enabled = true;
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
            GraphicWindow window = new GraphicWindow((Bitmap)NeighborhoodPicture.Image, (Bitmap)inputPicture.ToBitmap());
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
            if (picture != null)
            {
                Image<Gray, byte> imageGray = picture.Convert<Gray, byte>();
                Image<Gray, float> imageLaplacian = new Image<Gray, float>(picture.Width, picture.Height, new Gray(0));

                imageLaplacian = imageGray.Laplace(7);
                NeighborhoodPicture.Image = imageLaplacian.ToBitmap();
                Histogram();
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                Image<Gray, byte> imageCanny = new Image<Gray, byte>(picture.Width, picture.Height, new Gray(0));
                imageCanny = picture.Canny(20, 50);
                NeighborhoodPicture.Image = imageCanny.ToBitmap();
                Histogram();
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                picture = picture.SmoothGaussian(9);
                Image<Gray, byte> imageGray = picture.Convert<Gray, byte>();
                Image<Gray, float> imageSobel = imageGray.Sobel(0, 1, 3).Add(imageGray.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
                NeighborhoodPicture.Image = imageSobel.ToBitmap();
                Histogram();
            }
        }

        private void sharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SharpeningWindow window = new SharpeningWindow(picture,inputPicture);
            window.Show();
            this.Close();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat srcimg = Utility.GetMatFromSDImage(NeighborhoodPicture.Image);
            Mat dstimg = new Mat();
            CvInvoke.MedianBlur(srcimg, dstimg, 3);
            NeighborhoodPicture.Image = dstimg.ToBitmap();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat srcimg = Utility.GetMatFromSDImage(NeighborhoodPicture.Image);
            Mat dstimg = new Mat();
            CvInvoke.MedianBlur(srcimg, dstimg, 5);
            NeighborhoodPicture.Image = dstimg.ToBitmap();
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat srcimg = Utility.GetMatFromSDImage(NeighborhoodPicture.Image);
            Mat dstimg = new Mat();
            CvInvoke.MedianBlur(srcimg, dstimg, 7);
            NeighborhoodPicture.Image = dstimg.ToBitmap();
        }

        private void x11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat srcimg = Utility.GetMatFromSDImage(NeighborhoodPicture.Image);
            Mat dstimg = new Mat();
            CvInvoke.MedianBlur(srcimg, dstimg, 11);
            NeighborhoodPicture.Image = dstimg.ToBitmap();
        }
    }
}
