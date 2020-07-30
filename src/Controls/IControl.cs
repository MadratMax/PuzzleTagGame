using System.Drawing;

namespace PuzzleTag.Controls
{
    interface IControl
    {
        bool Enabled { get; set; }

        bool Visible { get; set; }

        string Text { get; set; }

        bool Closed { get; set; }

        int Id { get; set; }

        Size Size { get; set; }

        Image Image { get; }

        string GetName();

        void SetName(string name);

        void Click();

        void HideImage();

        void ShowImage();

        void SetImage(Image image);

        void SetClosedCardImage(Image image);
    }
}
