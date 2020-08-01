using System.Collections.Generic;

namespace PuzzleTag.FileManager.Library
{
    class ImageLibrary
    {
        private List<CustomImage> imageCollection;
        private CustomImage mainImage;
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

        public void SetMainImage(CustomImage image)
        {
            mainImage = image;
        }

        public CustomImage GetWinnerImage()
        {
            return winnerImage;
        }

        public CustomImage GetMainImage()
        {
            return mainImage;
        }

        public void SetClosedCardImage(CustomImage image)
        {
            closedCardImage = image;
        }

        public CustomImage GetClosedCardImage()
        {
            return closedCardImage;
        }

        public void AddCategory(string category)
        {
            if (!categories.Contains(category))
            {
                categories.Add(category);
            }
        }

        public void RemoveCategory(string category)
        {
            if (categories.Contains(category))
            {
                categories.Remove(category);
            }
        }

        public List<string> GetCategories()
        {
            return categories;
        }
    }
}
