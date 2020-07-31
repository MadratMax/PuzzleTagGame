using System.Drawing;

namespace PuzzleTag.FileManager.Library
{
    class CustomImage
    {
        private Image image;

        public string Name;

        public string SpecialName;

        public int Id;

        public string Category;

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                Id = value.GetHashCode();
                image = value;
            }
        }

        public bool AllowUpdate;
    }
}
