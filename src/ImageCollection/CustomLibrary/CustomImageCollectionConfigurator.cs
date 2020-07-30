using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<CustomImage> GetImagesByCategory(string category)
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
                    Name = image.GetHashCode().ToString(),
                    Category = category,
                    Image = image
                };

                imageLib.AddImageToLib(newImage);
            }

            return imageLib.GetCollection();
        }
    }
}
