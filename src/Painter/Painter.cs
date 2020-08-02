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
        private SolidBrush brush;
        private Pen pen;
        private ITool tool;
        private Graphics graph;
        private PictureBox pictureBox;
        private int X;
        private int Y;
        private int width;
        private int height;
        private Image image;

        public Painter(PictureBox pictureBox)
        {
            this.pen = new Pen(Color.Black);
            this.brush = new SolidBrush(Color.Black);

            this.pictureBox = pictureBox;
            this.brushSize.Width = 2;
            this.brushSize.Height = 2;
            InitEmptyPicture();
        }

        public void ChangeColor(Color color)
        {
            this.pen.Color = color;
            this.brush.Color = color;
        }

        public void ChangeBrushSize(Size size)
        {
            this.brushSize = size;
        }

        public void ChangeTool(ITool tool)
        {
            this.tool = tool;
        }

        public Image Image()
        {
            return image;
        }

        public Image InitEmptyPicture()
        {
            image = new Bitmap(pictureBox.Width, pictureBox.Height);
            SetImage(image);
            return image;
        }

        public void SetImage(Image image)
        {
            this.image = image;
            pictureBox.Image = image;
            RefreshPicture();
        }

        public void RefreshPicture()
        {
            pictureBox.Refresh();
        }

        public void Paint(int startPointX, int startPointY)
        {
            graph = Graphics.FromImage(image);
            //graph.DrawEllipse(pen, startPointX, startPointY, brushSize.Width, brushSize.Height);

            graph.FillRectangle(brush, new Rectangle(startPointX, startPointY, brushSize.Width, brushSize.Height));

            RefreshPicture();
        }

        public void Clear()
        {
            image = InitEmptyPicture();
            RefreshPicture();
        }

        public void CreateImage(PictureBox pictureBox)
        {
            pictureBox.DrawToBitmap((Bitmap)image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            image = pictureBox.Image;
        }
    }
}
