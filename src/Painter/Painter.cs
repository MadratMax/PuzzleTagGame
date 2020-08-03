using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

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
        private int toolWidth = 2;
        private int toolHeight = 2;
        private Image image;

        public Painter(PictureBox pictureBox)
        {
            this.pen = new Pen(Color.Black);
            this.pen.SetLineCap(
                System.Drawing.Drawing2D.LineCap.Round, 
                System.Drawing.Drawing2D.LineCap.Round,
                System.Drawing.Drawing2D.DashCap.Round
                );

            this.brush = new SolidBrush(Color.Black);
            ChangeBrushSize(new Size(this.toolWidth, this.toolHeight));

            this.pictureBox = pictureBox;
            InitEmptyPicture();
        }

        public void ChangeColor(Color color)
        {
            this.pen.Color = color;
            this.brush.Color = color;
        }

        public void ChangeBrushSize(Size size)
        {
            this.toolWidth = size.Width;
            this.toolHeight = size.Height;
            this.brushSize = new Size(this.toolWidth, this.toolHeight);
        }

        public void ChangePenSize(Size size)
        {
            this.toolWidth = size.Width;
            this.toolHeight = size.Height;
            this.pen.Width = size.Width;
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

        public void Paint(int oldX, int oldY, int startPointX, int startPointY, bool pointOnly = false)
        {
            graph = Graphics.FromImage(image);

            if (pointOnly)
            {
                if (startPointX == oldX && startPointY == oldY)
                {
                    //graph.FillEllipse(brush, startPointX - 2, startPointY - 2, toolWidth, toolHeight);
                    //RefreshPicture();
                    //return;
                }
            }

            graph.DrawLine(pen, oldX, oldY, startPointX, startPointY);

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
