using System.Collections.Generic;
using System.Linq;
using PuzzleTag.FileManager.Library;

namespace PuzzleTag.ImageCollection.CustomLibrary
{
    class CustomPaintLibrary
    {
        private List<CustomImage> imageList;

        public CustomPaintLibrary()
        {
            this.imageList = new List<CustomImage>();
        }

        public void AddPicture(CustomImage image, int index)
        {
            if (imageList.ElementAtOrDefault(index-1) != null)
            {
                imageList.RemoveAt(index-1);
                imageList.Insert(index-1, image);
            }
            else
            {
                imageList.Add(image);
            }
        }

        public CustomImage GetImageByNumber(int index)
        {
            return imageList.ElementAtOrDefault(index-1) ?? null;
        }

        public List<CustomImage> GetCollection()
        {
            var increasedImageList = imageList.Concat(imageList)
                //.Concat(imageList)
                .ToList();
            return increasedImageList;
        }

        public bool IsImageExistWithNumber(int index)
        {
            return imageList.ElementAtOrDefault(index-1) != null;
        }
    }
}
