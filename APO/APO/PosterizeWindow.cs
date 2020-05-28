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
    public partial class PosterizeWindow : Form
    {

        private GraphicWindow pictureWindow;
        private Bitmap defaultpicture;
        public PosterizeWindow(GraphicWindow pictureWindow)
        {
            InitializeComponent();
            this.pictureWindow = pictureWindow;
            PosterizeWindowPicture.Image = this.pictureWindow.picture;
            defaultpicture = this.pictureWindow.picture;
            PosterizeWindowPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            PosterizeWindowPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PosterizeWindowPicture.Show();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PosterizeWindowPicture.Image = this.pictureWindow.picture;         
        }

        private void PosterizeButton_Click(object sender, EventArgs e)
        {
                PosterizeWindowPicture.Image = Utility.Posterize((Bitmap)PosterizeWindowPicture.Image, Convert.ToInt32(textboxColors.Text));
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            GraphicWindow window = new GraphicWindow((Bitmap)PosterizeWindowPicture.Image, (Bitmap)defaultpicture);
            window.Show();
            this.Close();
        }
    }
}
