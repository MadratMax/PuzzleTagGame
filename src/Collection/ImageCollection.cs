using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PuzzleTag.Collection
{
    class ImageCollection
    {
        private List<ImageModel> collection;

        public ImageCollection()
        {
            this.collection = new List<ImageModel>();
        }

        public void Add(Image image, string name)
        {
            var newImage = new ImageModel { 
                Id = 1,
                Name = name, 
                image = image };

            collection.Add(newImage);
        }

        public List<ImageModel> GetImages()
        {
            return collection;
        }

        public ImageModel GetImageByName(string name)
        {
            return collection.FirstOrDefault(n => n.Name == name);
        }

        public ImageModel GetImageById(int id)
        {
            return collection.FirstOrDefault(n => n.Id == id);
        }
    }
}
