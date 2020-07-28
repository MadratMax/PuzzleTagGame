using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.FileManager.Library
{
    class ImageLibrary
    {
        private List<CustomImage> imageCollection;
        private CustomImage winnerImage;
        private CustomImage closedCardImage;
        private List<string> categories;
        private int counter;

        public ImageLibrary()
        {
            this.imageCollection = new List<CustomImage>();
            this.categories = new List<string>();
        }

        public List<CustomImage> GetCollection()
        {
            return imageCollection;
        }

        public void AddImageToLib(CustomImage image)
        {
            if (!categories.Contains(image.Category))
            {
                categories.Add(image.Category);
            }

            imageCollection.Add(image);
        }

        public void SetWinnerImage(CustomImage image)
        {
            winnerImage = image;
        }

        public CustomImage GetWinnerImage()
        {
            return winnerImage;
        }

        public void SetClosedCardImage(CustomImage image)
        {
            closedCardImage = image;
        }

        public CustomImage GetClosedCardImage()
        {
            return closedCardImage;
        }

        public List<string> GetCategories()
        {
            return categories;
        }
    }
}
