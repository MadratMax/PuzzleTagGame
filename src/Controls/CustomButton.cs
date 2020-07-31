using System.Drawing;
using System.Windows.Forms;

namespace PuzzleTag.Controls
{
    class CustomButton : IControl
    {
        private Button button;
        private Image buttonImage;
        private Image closedCardImage;
        private bool closed;
        private int imageId;

        public CustomButton(Button button)
        {
            this.button = button;
        }

        public bool Enabled { get => button.Enabled; set => button.Enabled = value; }

        public bool Visible { get => button.Visible; set => button.Visible = value; }

        public bool Closed { get => closed; set => closed = value; }

        public string Text
        {
            get => button.Text;
            set
            {
                button.Text = value;
                this.HideImage();
            }
        }

        public int Id { get; set; }

        public int ImageId => imageId;

        public Size Size { get => button.Size; set => button.Size = value; }

        public Image Image => buttonImage;

        public string GetName()
        {
            return button.Name;
        }

        public void SetName(string name)
        {
            button.Name = name;
        }

        public void Click()
        {
            button.PerformClick();
        }

        public void HideImage()
        {
            button.Image = null;
        }

        public void ShowImage()
        {
            button.Image = buttonImage;
            closed = false;
        }

        public void ShowClosedCardImage()
        {
            try
            {
                button.Image = closedCardImage;
                closed = true;
            }
            catch
            {
                
            }
        }

        public void SetImage(Image image)
        {
            buttonImage = image;
            imageId = image.GetHashCode();
        }

        public void SetClosedCardImage(Image image)
        {
            closedCardImage = image;
        }

        public Button Element()
        {
            return this.button;
        }
    }
}
