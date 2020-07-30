using System.Collections.Generic;
using System.Drawing;
using PuzzleTag.FileManager;
using PuzzleTag.FileManager.Library;

namespace PuzzleTag.ImageCollection.CustomLibrary
{
    class CustomImageCollectionConfigurator
    {
        private ImageProvider imageProvider;
        private ImageLibraryManager libManager;

        public CustomImageCollectionConfigurator(
            string serviceApiUrl,
            ImageLibraryManager libManager)
        {
            this.imageProvider = new ImageProvider(serviceApiUrl);
            this.libManager = libManager;
        }

        public List<CustomImage> GenerateImageCollectionByCategory(string category, int weidth, int height)
        {
            var newImageCollection = new List<CustomImage>(16);
            Image image = null;

            for (int i = 0; i < newImageCollection.Capacity; i++)
            {
                image = imageProvider.SetDefaultSize(weidth, height).GetImageByCategory(category);

                var newImage = new CustomImage
                {
                    Name = $"{category}_{i}",
                    Category = category,
                    Image = image
                };

                newImageCollection.Add(newImage);
            }

            libManager.AddCategory(category);
            libManager.InitializeNewCollection(newImageCollection);

            return libManager.GetImageCollection();
        }
    }
}
