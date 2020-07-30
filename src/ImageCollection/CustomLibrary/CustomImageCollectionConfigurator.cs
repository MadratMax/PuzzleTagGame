using System.Collections.Generic;
using System.Drawing;
using PuzzleTag.FileManager.Library;

namespace PuzzleTag.ImageCollection.CustomLibrary
{
    class CustomImageCollectionConfigurator
    {
        private ImageProvider imageProvider;
        private ImageLibrary imageLib;

        public CustomImageCollectionConfigurator(
            string serviceApiUrl, 
            ImageLibrary imageLib)
        {
            this.imageProvider = new ImageProvider(serviceApiUrl);
        }

        public List<CustomImage> GenerateImageCollectionByCategory(string category)
        {
            var collection = new List<Image>(16);
            Image image = null;

            for (int i = 0; i < collection.Count; i++)
            {
                image = imageProvider.GetImageByCategory(category);
                collection.Add(image);
            }

            foreach (var customImage in collection)
            {
                var newImage = new CustomImage
                {
                    Name = $"{category}_{collection.IndexOf(customImage)}",
                    Category = category,
                    Image = image
                };

                imageLib.AddImageToLib(newImage);
            }

            return imageLib.GetCollection();
        }
    }
}
