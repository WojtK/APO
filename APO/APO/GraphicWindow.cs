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

        private void cloneWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicWindow graphicWindow = new GraphicWindow((Bitmap)PictureBox.Image);
            graphicWindow.Size = this.Size;
            graphicWindow.Show();
        }
        private void saveHistogramToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            save.FileName = "Histogram";
            save.ShowDialog();

            try { this.GraphicWindowChart.SaveImage(save.FileName, ChartImageFormat.Jpeg); }
            catch { MessageBox.Show("Failed to save"); }
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)PictureBox.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");
            int sum = 0;

            GraphicWindowChart.Series.Add("Red");
            GraphicWindowChart.Series.Add("Blue");
            GraphicWindowChart.Series.Add("Green");
            GraphicWindowChart.Series["Red"].Color = Color.Red;
            GraphicWindowChart.Series["Blue"].Color = Color.Blue;
            GraphicWindowChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.GraphicWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.GraphicWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.GraphicWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                sum += RedLut[i];
            }

           // PixelsTextBox.Text = sum.ToString();
           // histogramToolStripMenuItem1.Enabled = true;
          //  RGBHistogramMenuStrip.Enabled = false;
          //  GreyHistogramMenuStripItem.Enabled = false;
           // StretchButton.Enabled = true;
            this.chart = GraphicWindowChart;
            RGB = true;
        }

        private void grayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)PictureBox.Image);
            int[] GrayLut = Utility.HistogramLUT(map);
            int sum = 0;
            GraphicWindowChart.Series.Add("Gray");
            GraphicWindowChart.Series["Gray"].Color = Color.Gray;
            for (int i = 0; i < GrayLut.Length; i++)
            {
                this.GraphicWindowChart.Series["Gray"].Points.AddXY(i, GrayLut[i]);
                sum += GrayLut[i];
            }

            // PixelsTextBox.Text = sum.ToString();
           // histogramToolStripMenuItem1.Enabled = true;
            grayToolStripMenuItem.Enabled = false;
            //  RGBHistogramMenuStrip.Enabled = false;
            //  StretchButton.Enabled = true;
            this.chart = GraphicWindowChart;
            Gray = true;
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void negationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Utility.Negation((Bitmap)PictureBox.Image);
            
            Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)PictureBox.Image);
            int[] RedLut = Utility.HistogramLUT(map, "red");
            int[] GreenLut = Utility.HistogramLUT(map, "green");
            int[] BlueLut = Utility.HistogramLUT(map, "blue");

            GraphicWindowChart.Series.Clear();
            GraphicWindowChart.Series.Add("Red");
            GraphicWindowChart.Series.Add("Blue");
            GraphicWindowChart.Series.Add("Green");
            GraphicWindowChart.Series["Red"].Color = Color.Red;
            GraphicWindowChart.Series["Blue"].Color = Color.Blue;
            GraphicWindowChart.Series["Green"].Color = Color.Green;

            for (int i = 0; i < RedLut.Length; i++)
            {
                this.GraphicWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                this.GraphicWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                this.GraphicWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
            }
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Gray)
            {

                PictureBox.Image = Utility.EqualGray((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)PictureBox.Image);
                int[] GrayLut = Utility.HistogramLUT(map);
                GraphicWindowChart.Series.Clear();
                GraphicWindowChart.Series.Add("Equal");
                GraphicWindowChart.Series["Equal"].Color = Color.Violet;
                for (int i = 0; i < GrayLut.Length; i++)
                {
                    this.GraphicWindowChart.Series["Equal"].Points.AddXY(i, GrayLut[i]);
                }
            }
            if (RGB)
            {
                PictureBox.Image = Utility.EqualRGB((Bitmap)PictureBox.Image);
                Dictionary<Color, int> map = Utility.HistogramMap((Bitmap)PictureBox.Image);
                int[] RedLut = Utility.HistogramLUT(map, "red");
                int[] GreenLut = Utility.HistogramLUT(map, "green");
                int[] BlueLut = Utility.HistogramLUT(map, "blue");

                GraphicWindowChart.Series.Clear();
                GraphicWindowChart.Series.Add("Red");
                GraphicWindowChart.Series.Add("Blue");
                GraphicWindowChart.Series.Add("Green");
                GraphicWindowChart.Series["Red"].Color = Color.Red;
                GraphicWindowChart.Series["Blue"].Color = Color.Blue;
                GraphicWindowChart.Series["Green"].Color = Color.Green;

                for (int i = 0; i < RedLut.Length; i++)
                {
                    this.GraphicWindowChart.Series["Red"].Points.AddXY(i, RedLut[i]);
                    this.GraphicWindowChart.Series["Green"].Points.AddXY(i, GreenLut[i]);
                    this.GraphicWindowChart.Series["Blue"].Points.AddXY(i, BlueLut[i]);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
