using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PuzzleTag.FileManager.Library;
using PuzzleTag.ImageCollection.CustomLibrary;
using PuzzleTag.Notification;

namespace PuzzleTag.UI
{
    partial class PaintForm : Form
    {
        private int pointX = 0;
        private int pointY = 0;
        private PaintForm paintPanelImage;
        private SettingsForm settingsForm;
        private string newCollectionName;
        private PuzzleTag baseForm;
        private Graphics graph;
        private List<CustomImage> imageCollection;
        private Bitmap picture;
        private CustomPaintLibrary pictureLib;
        private int picNum = 1;


        public PaintForm(SettingsForm settingsForm, PuzzleTag baseForm, string newCollectionName)
        {
            this.settingsForm = settingsForm;
            this.baseForm = baseForm;
            this.newCollectionName = newCollectionName;
            InitializeComponent();
            InitPictureLibrary();
        }

        private void InitPictureLibrary()
        {
            this.pictureLib = new CustomPaintLibrary();
        }

        public PaintForm GetLastPaint()
        {
            return paintPanelImage;
        }

        public Graphics GetLastImage()
        {
            return graph;
        }

        public List<CustomImage> GetCollection()
        {
            return imageCollection;
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            graph = Graphics.FromImage(PictureBox.Image);
            graph.DrawEllipse(Pens.Red, pointX, pointY, 3, 2);

            PictureBox.Refresh();
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                PaintPanel_Paint(this, null);
            }
        }

        private void SavePaintButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SavePicture()
        {
            PictureBox.Refresh();

            this.PictureBox.DrawToBitmap(picture, new Rectangle(0, 0, this.PictureBox.Width, this.PictureBox.Height));

            var pictureName = PicNumberTextBox.Text;

            var newPicture =
                new CustomImage
                {
                    Name = $"{pictureName}.jpeg",
                    Id = picture.GetHashCode(),
                    Category = newCollectionName,
                    Image = PictureBox.Image
                };
            
            pictureLib.AddPicture(newPicture, picNum);
        }

        private void BackToSettings()
        {
            paintPanelImage = this;
            baseForm.Enabled = true;
            Owner.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SavePicture();

            if (pictureLib.GetCollection().Count == 16)
            {
                imageCollection = pictureLib.GetCollection();
                BackToSettings();
            }
            else
            {
                var popUp = new TimedPopUp();
                popUp.Set("Не все изображения готовы для коллекции");
                popUp.Show();
            }
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            Invoke((Action)(() => settingsForm.Hide()));
            Invoke((Action)(() => baseForm.Enabled = false));
            
            InitControls();
            InitEmptyPictureBox();
        }

        private void InitEmptyPictureBox(Image initialImage = null)
        {
            if (initialImage == null)
            {
                picture = new Bitmap(PictureBox.Width, PictureBox.Height);
            }
            else
            {
                picture = (Bitmap)initialImage;
            }

            PictureBox.Image = picture;
            Refresh();
        }

        private void InitControls()
        {
            PicNumberTextBox.Text = picNum.ToString();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (picNum != 16)
            {
                SavePicture();

                picNum++;
                PicNumberTextBox.Text = picNum.ToString();

                var nextPicture = pictureLib.GetImageByNumber(picNum);

                InitEmptyPictureBox(nextPicture?.Image);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (picNum != 1)
            {
                SavePicture();

                picNum--;
                PicNumberTextBox.Text = picNum.ToString();

                var nextPicture = pictureLib.GetImageByNumber(picNum);

                InitEmptyPictureBox(nextPicture?.Image);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            BackToSettings();
        }
    }
}
