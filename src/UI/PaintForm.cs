using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PuzzleTag.FileManager.Library;
using PuzzleTag.ImageCollection.CustomLibrary;
using PuzzleTag.Notification;
using PuzzleTag.SoundMaster;

namespace PuzzleTag.UI
{
    partial class PaintForm : Form
    {
        private bool draw;
        private int pointX = 0;
        private int pointY = 0;
        private int oldX;
        private int oldY;
        private PaintForm paintPanelImage;
        private SettingsForm settingsForm;
        private string newCollectionName;
        private PuzzleTag baseForm;
        private Graphics graph;
        private List<CustomImage> imageCollection;
        private CustomPaintLibrary paintLibrary;
        private Painter.Painter painter;
        private List<Point> points;
        private int picNum = 1;


        public PaintForm(SettingsForm settingsForm, PuzzleTag baseForm, string newCollectionName)
        {
            this.settingsForm = settingsForm;
            this.baseForm = baseForm;
            this.newCollectionName = newCollectionName;
            InitializeComponent();
            InitPictureLibrary();
            points = new List<Point>();
            draw = true;
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            Invoke((Action)(() => settingsForm.Hide()));
            Invoke((Action)(() => baseForm.Enabled = false));
            
            this.painter = new Painter.Painter(this.PictureBox);

            //TODO remove
            this.painter.ChangeBrushSize(new Size(10, 10));

            SetupKeyDownEvents(this);
            InitControls();
            InitEmptyPictureBox();
        }

        private void SetupKeyDownEvents(PaintForm paintForm)
        {
            foreach (Control control in paintForm.Controls)
            {
                control.MouseDown += PaintFormControlsCollection_KeyDown;
            }
        }

        private void PaintFormControlsCollection_KeyDown(object sender, MouseEventArgs e)
        {
            if (sender != PictureBox)
            {
                this.draw = false;
            }
        }

        private void InitPictureLibrary()
        {
            this.paintLibrary = new CustomPaintLibrary();
        }

        public List<CustomImage> GetCollection()
        {
            return imageCollection;
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                painter.Paint(oldX, oldY, pointX, pointY);
                oldX = pointX;
                oldY = pointY;
            }
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

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            oldX = e.X;
            oldY = e.Y;
            this.draw = true;
        }

        private void SaveImage()
        {
            painter.CreateImage(PictureBox);

            var image = painter.Image();
            var imageName = PicNumberTextBox.Text;

            var newPicture =
                new CustomImage
                {
                    Name = $"{imageName}.jpeg",
                    Id = image.GetHashCode(),
                    Category = newCollectionName,
                    Image = image
                };
            
            paintLibrary.AddPicture(newPicture, picNum);
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
            SaveImage();

            var collection = paintLibrary.GetCollection();

            if (collection.Count == 32)
            {
                imageCollection = collection;
                BackToSettings();
            }
            else
            {
                var popUp = new TimedPopUp();
                popUp.Set("Не все изображения готовы для коллекции");
                popUp.Show();
            }
        }

        private void InitControls()
        {
            PicNumberTextBox.Text = picNum.ToString();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (picNum != 16)
            {
                SaveImage();

                picNum++;
                PicNumberTextBox.Text = picNum.ToString();

                var nextPicture = paintLibrary.GetImageByNumber(picNum);

                InitEmptyPictureBox(nextPicture?.Image);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (picNum != 1)
            {
                SaveImage();

                picNum--;
                PicNumberTextBox.Text = picNum.ToString();

                var nextPicture = paintLibrary.GetImageByNumber(picNum);

                InitEmptyPictureBox(nextPicture?.Image);
            }
        }

        private void InitEmptyPictureBox(Image initialImage = null)
        {
            if (initialImage == null)
            {
                painter.InitEmptyPicture();
            }
            else
            {
                painter.SetImage(initialImage);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlaySettingsSound();

            bool needReset = false;

            var confirm = GetConfirmStatus("Выйти из редактора без сохранения?");
            needReset = confirm.Yes;

            if (needReset)
            {
                BackToSettings();
            }

            confirm?.Dispose();
            this.Enabled = true;
        }

        private ConfirmDialogForm GetConfirmStatus(string confirmMessage)
        {
            var confirm = new ConfirmDialogForm(confirmMessage);
            SoundPlayer.PlaySettingsSound();
            confirm.StartPosition = FormStartPosition.Manual;
            confirm.Location = this.Location;
            confirm.StartPosition = FormStartPosition.CenterParent;
            confirm.BackgroundImageLayout = ImageLayout.Stretch;
            this.Enabled = false;
            confirm.ShowDialog(this);
            return confirm;
        }

        private void BrushSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            painter.ChangePenSize(new Size(BrushSizeComboBox.SelectedIndex+1, 0));
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            this.Enabled = false;
            this.SendToBack();
            var answer = colorDialog.ShowDialog();

            if (answer == DialogResult.OK)
            {
                painter.ChangeColor(colorDialog.Color);
                ColorIndicator.BackColor = colorDialog.Color;
            }

            this.Enabled = true;
            this.BringToFront();
        }

        private void ToolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            painter.Clear();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            points.Clear();
        }

        private void ColorIndicator_Click(object sender, EventArgs e)
        {
            ColorButton.PerformClick();
        }

        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
