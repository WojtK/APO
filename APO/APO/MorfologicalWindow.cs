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
    public partial class MorphologicalWindow : Form
    {
        public Image<Bgra, byte> chart;
        public Image<Bgra, byte> picture;
        public Image<Bgra, byte> defaultpicture;
        private Stack<Image<Bgra, byte>> imageBackup;
        private Stack<Image<Bgra, byte>> chartBackup;

        private Emgu.CV.CvEnum.BorderType borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        private Size elementSize = new Size(3, 3);
        private Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));


        public MorphologicalWindow()
        {
            InitializeComponent();
            imageBackup = new Stack<Image<Bgra, byte>>();
            chartBackup = new Stack<Image<Bgra, byte>>();
        }

        private void ErodeButton_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                this.imageBackup.Push(this.picture);
                this.chartBackup.Push(this.picture);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(picture.Size.Width, picture.Size.Height);
                CvInvoke.Erode(picture, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.picture = bitmap.ToImage<Bgra, byte>();
                Utility.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
            }
        }

        private void DilateButton_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                imageBackup.Push(picture);
                chartBackup.Push(chart);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(picture.Size.Width, picture.Size.Height);
                CvInvoke.Dilate(picture, resultImage, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.picture = bitmap.ToImage<Bgra, byte>();
                Utility.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
            }
        }

        private void OpeningButton_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                imageBackup.Push(picture);
                chartBackup.Push(chart);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(picture.Size.Width, picture.Size.Height);
                CvInvoke.MorphologyEx(picture, resultImage,
                                        Emgu.CV.CvEnum.MorphOp.Open,
                                        element, new Point(-1, -1), 1,
                                        borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.picture = bitmap.ToImage<Bgra, byte>();
                Utility.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
            }
        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                imageBackup.Push(picture);
                chartBackup.Push(chart);
                Image<Bgra, byte> resultImage = new Image<Bgra, byte>(picture.Size.Width, picture.Size.Height);
                CvInvoke.MorphologyEx(picture, resultImage,
                                        Emgu.CV.CvEnum.MorphOp.Close,
                                        element, new Point(-1, -1), 1,
                                        borderType, new MCvScalar(255, 255, 255));
                MorfologicalPictureBox.Image = resultImage.ToBitmap();
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.picture = bitmap.ToImage<Bgra, byte>();
                Utility.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            try
            {
                MorfologicalPictureBox.Image = new Bitmap(dialog.FileName);
                Bitmap bitmap = (Bitmap)MorfologicalPictureBox.Image;
                this.picture = bitmap.ToImage<Bgra, byte>();
                defaultpicture = picture;
                this.imageBackup.Push(this.picture);
                this.chartBackup.Push(this.picture);
                Utility.Histogram(MorfologicalChart, (Bitmap)MorfologicalPictureBox.Image);
                saveHistogramToolStripMenuItem.Enabled = true;
                savePictureToolStripMenuItem.Enabled = true;
                SkeletonButton.Enabled = true;
                ClosingButton.Enabled = true;
                OpeningButton.Enabled = true;
                ErodeButton.Enabled = true;
                DilateButton.Enabled = true;
                undoToolStripMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("You have not selected anything \nYou must select a picture");
            }
        }


        private void IsolatedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Isolated;
        }

        private void ReflectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Reflect;
        }

        private void ReplicateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            borderType = Emgu.CV.CvEnum.BorderType.Replicate;
        }

        private void DiamondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, elementSize, new Point(-1, -1));
        }

        private void SquareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, elementSize, new Point(-1, -1));
        }
        private void RadioButtonChange()
        {
            if (RadioButton3X3.Checked)
            {
                elementSize = new Size(3, 3);
            }
            if (RadioButton5X5.Checked)
            {
                elementSize = new Size(5, 5);
            }
            if (RadioButton7X7.Checked)
            {
                elementSize = new Size(7, 7);
            }
        }

        private void RadioButton3X3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }

        private void RadioButton5X5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }

        private void RadioButton7X7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChange();
        }

        private void SkeletonButton_Click(object sender, EventArgs e)
        {
            if (picture != null)
            {
                imageBackup.Push(picture);
                chartBackup.Push(chart);

                Image<Gray, byte> skel = new Image<Gray, byte>(MorfologicalPictureBox.Image.Size);
                for (int y = 0; y < skel.Height; y++)
                    for (int x = 0; x < skel.Width; x++)
                        skel.Data[y, x, 0] = 0;

                MorfologicalPictureBox.Image = skel.ToBitmap();

                Image<Gray, byte> img = skel.Copy();
                for (int y = 0; y < skel.Height; y++)
                    for (int x = 0; x < skel.Width; x++)
                        img.Data[y, x, 0] = picture.Data[y, x, 0];

                element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
                Image<Gray, byte> temp;

                bool done = false;
                do
                {
                    temp = img.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Open, element, new Point(-1, -1), 1, borderType, new MCvScalar(255, 255, 255));
                    temp = temp.Not();
                    temp = temp.And(img);
                    skel = skel.Or(temp);
                    img = img.Erode(1);
                    double[] min, max;
                    Point[] pmin, pmax;
                    img.MinMax(out min, out max, out pmin, out pmax);
                    done = (max[0] == 0);
                } while (!done); 

                MorfologicalPictureBox.Image = skel.ToBitmap();
                picture = skel.ToBitmap().ToImage<Bgra, byte>();
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBackup.Count > 1)
            {
                picture = imageBackup.Pop();
                MorfologicalPictureBox.Image = picture.ToBitmap();
            }
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Image";
            x.ShowDialog();

            try { MorfologicalPictureBox.Image.Save(x.FileName); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void saveHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            x.FileName = "Histogram";
            x.ShowDialog();

            try { this.MorfologicalChart.SaveImage(x.FileName, ChartImageFormat.Jpeg); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorfologicalPictureBox.Image = defaultpicture.ToBitmap();
        }
    }
}
