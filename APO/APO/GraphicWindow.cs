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

        public Bitmap picture { get; set; }

        public Bitmap defaultpicture { get; set; }
        public Chart chart { get; set; }
        public bool Gray { get; set; }
        public bool RGB { get; set; }



        public GraphicWindow(Bitmap picture)
        {
            InitializeComponent();

            PictureBox.Image = picture;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.picture = picture;
            defaultpicture = picture;
            Gray = false;
            RGB = false;
        }

        public GraphicWindow(Bitmap picture, Bitmap defaultpicture)
        {
            InitializeComponent();

            PictureBox.Image = picture;
            PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.picture = picture;
            this.defaultpicture = defaultpicture;
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
            GraphicWindowChart.Series.Clear();
            GraphicWindowChart.Visible = true;
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

            rGBToolStripMenuItem.Enabled = false;
            equalizationToolStripMenuItem.Enabled = true;
            selectiveEqualizationToolStripMenuItem.Enabled = true;
            saveHistogramToolStripMenuItem.Enabled = true;
            grayToolStripMenuItem.Enabled = true;
            stretchToolStripMenuItem.Enabled = true;
            this.chart = GraphicWindowChart;
            RGB = true;
        }

        private void grayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GraphicWindowChart.Series.Clear();
            GraphicWindowChart.Visible = true;
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

            grayToolStripMenuItem.Enabled = false;
            equalizationToolStripMenuItem.Enabled = true;
            selectiveEqualizationToolStripMenuItem.Enabled = true;
            rGBToolStripMenuItem.Enabled = true;
            stretchToolStripMenuItem.Enabled = true;
            saveHistogramToolStripMenuItem.Enabled = true;
            stretchToolStripMenuItem.Enabled = true;
            this.chart = GraphicWindowChart;
            Gray = true;
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pic = new SaveFileDialog();
            pic.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            pic.FileName = "Image";
            pic.ShowDialog();

            try { this.PictureBox.Image.Save(pic.FileName); }
            catch { MessageBox.Show("Failed to save"); }
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

        private void selectiveEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Gray)
            {
                PictureBox.Image = Utility.SelectiveEqualGray((Bitmap)PictureBox.Image);
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
                PictureBox.Image = Utility.SelectiveEqualRGB((Bitmap)PictureBox.Image);
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

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StretchWindow stretchWindow = new StretchWindow(this);
            stretchWindow.Show();
            this.Close();
        }

        private void thresholdingToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
                PictureBox.Image = Utility.Thresholding((Bitmap)PictureBox.Image, Convert.ToInt32(numericUpDown1.Value));

        }

        private void thresholdingGrayLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {        
                PictureBox.Image = Utility.Thresholding2((Bitmap)PictureBox.Image, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));              

        }

        private void defaultbutton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = this.defaultpicture;
            GraphicWindowChart.Series.Clear();
            grayToolStripMenuItem.Enabled = true;
            rGBToolStripMenuItem.Enabled = true;
            stretchToolStripMenuItem.Enabled = false;
            equalizationToolStripMenuItem.Enabled = false;
            selectiveEqualizationToolStripMenuItem.Enabled = false;
            saveHistogramToolStripMenuItem.Enabled = false;
        }

        private void posterizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosterizeWindow posterizeWindow = new PosterizeWindow(this);
            posterizeWindow.Show();
            this.Close();
        }
    }
}


