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
    public partial class StretchWindow : Form
    {

        private GraphicWindow pictureWindow;
        private System.IO.MemoryStream myStream = new System.IO.MemoryStream();

        public StretchWindow(GraphicWindow pictureWindow)
        {
            InitializeComponent();
            this.pictureWindow = pictureWindow;
            StretchWindowPictureBox.Image = this.pictureWindow.picture;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            StretchWindowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            StretchWindowPictureBox.Show();

            textBoxMax.Text = "255";
            textBoxMin.Text = "1";

            this.pictureWindow.chart.Serializer.Save(myStream);
            StretchChart.Serializer.Load(myStream);
            StretchChart.Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            StretchWindowPictureBox.Image = this.pictureWindow.picture;

            if (this.pictureWindow.Gray)
            {
                Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)this.pictureWindow.picture);
                int[] GrayLut = Utility.HistogramLUT(map);
                StretchChart.Series.Clear();
                StretchChart.Series.Add("Gray");
                StretchChart.Series["Gray"].Color = Color.Gray;
                for (int i = 0; i < GrayLut.Length; i++)
                {
                    this.StretchChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
                }
            }

            if (this.pictureWindow.RGB)
            {
                Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)this.pictureWindow.picture);
                int[] RedLut = Utility.HistogramLUT(map, "red");
                int[] GreenLut = Utility.HistogramLUT(map, "green");
                int[] BlueLut = Utility.HistogramLUT(map, "blue");

                StretchChart.Series.Clear();
                StretchChart.Series.Add("Red");
                StretchChart.Series.Add("Blue");
                StretchChart.Series.Add("Green");
                StretchChart.Series["Red"].Color = Color.Red;
                StretchChart.Series["Blue"].Color = Color.Blue;
                StretchChart.Series["Green"].Color = Color.Green;

                for (int i = 0; i < RedLut.Length; i++)
                {
                    this.StretchChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                    this.StretchChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                    this.StretchChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                }
            }

            textBoxMax.Text = "255";
            textBoxMin.Text = "1";
        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            GraphicWindow window = new GraphicWindow((Bitmap)StretchWindowPictureBox.Image);
            window.Show();
            this.Close();
        }

        private void Stretchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}