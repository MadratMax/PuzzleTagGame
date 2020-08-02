using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleTag.Painter
{
    class Painter
    {
        private Size brushSize;
        private Pen color;
        private Graphics graph;
        private PictureBox pictureBox;
        private int X;
        private int Y;
        private int width;
        private int height;
        Bitmap picture;
        private Image image;

        public Painter(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.brushSize.Width = 2;
            this.brushSize.Height = 2;
            InitEmptyPicture();
        }

        public void ChangeColor(Pen color)
        {
            this.color = color;
        }

        public void ChangeBrushSize(Size size)
        {
            this.brushSize = size;
        }

        public Image Image()
        {
            return image;
        }

        public Bitmap InitEmptyPicture()
        {
            picture = new Bitmap(width, height);

            return picture;
        }

        public void RefreshPicture()
        {
            pictureBox.Refresh();
        }

        public void Paint(int startPointX, int startPointY)
        {
            graph = Graphics.FromImage(image);
            graph.DrawEllipse(color, startPointX, startPointY, brushSize.Width, brushSize.Height);

            pictureBox.Refresh();
        }

        public void CreateImage(PictureBox pictureBox)
        {
            pictureBox.DrawToBitmap(picture, new Rectangle(0, 0, width, height));
            image = pictureBox.Image;
        }
    }
}
