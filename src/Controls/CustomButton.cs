using System.Drawing;
using System.Windows.Forms;

namespace PuzzleTag.Controls
{
    class CustomButton : IControl
    {
        private Button button;
        private Image buttonImage;

        public CustomButton(Button button)
        {
            this.button = button;
        }

        public bool Enabled { get => button.Enabled; set => button.Enabled = value; }

        public bool Visible { get => button.Visible; set => button.Visible = value; }

        public string Text
        {
            get => button.Text;
            set
            {
                button.Text = value;
                this.HideImage();
            }
        }

        public Size Size { get => button.Size; set => button.Size = value; }

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
            button.Text = string.Empty;
        }

        public void SetImage(Image image)
        {
            buttonImage = image;
        }
    }
}
