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
            var capacity = 16;

            for (int i = 0; i < capacity; i++)
            {
                Image image = imageProvider.SetDefaultSize(weidth, height).GetImageByCategory(category);

                var newImage = new CustomImage
                {
                    Name = $"{category}{i}.Jpeg",
                    Category = category,
                    AllowUpdate = true,
                    Image = image
                };

                var secondImage = new CustomImage
                {
                    Name = $"{category}{i}-second.Jpeg",
                    Category = category,
                    AllowUpdate = true,
                    Image = image
                };

                newImageCollection.Add(newImage);
                newImageCollection.Add(secondImage);
            }

            libManager.AddCategory(category);
            libManager.InitializeNewCollection(newImageCollection);

            return libManager.GetImageCollection();
        }

        public CustomImage UpdateImage(CustomImage customImage)
        {
            var width = customImage.Image.Width;
            var height = customImage.Image.Height;
            var category = customImage.Category;
            var name = customImage.Name;
            var newImageCollection = new List<CustomImage>();

            Image image = imageProvider.SetDefaultSize(width, height).GetImageByCategory(category);

            var newImage = new CustomImage
            {
                Name = $"updated-1-{name}",
                Category = category,
                AllowUpdate = true,
                Image = image
            };

            var secondImage = new CustomImage
            {
                Name = $"updated-2-{name}",
                Category = category,
                AllowUpdate = true,
                Image = image
            };

            libManager.RemoveImageFromCollection(customImage);
            newImageCollection.Add(newImage);
            newImageCollection.Add(secondImage);
            libManager.InitializeNewCollection(newImageCollection);
            return newImage;
        }
    }
}
