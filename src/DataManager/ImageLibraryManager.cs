using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using PuzzleTag.Configuration;
using PuzzleTag.FileManager.Library;

namespace PuzzleTag.FileManager
{
    class ImageLibraryManager
    {
        private string libraryPath;
        private string winnerImagePath;
        private string closedCardImagePath;
        private CustomImage winnerImage;
        private CustomImage closedCardImage;
        private List<CustomImage> imageCollection;
        private ImageLibrary imageLib;

        private FileManager fileManager;

        public ImageLibraryManager()
        {
            this.imageCollection = new List<CustomImage>();
            this.libraryPath = Settings.LibraryPath;
            this.winnerImagePath = Settings.WinnerImagePath;
            this.closedCardImagePath = Settings.ClosedCardImagePath;
            this.fileManager = new FileManager();
            this.imageLib = new ImageLibrary();
        }

        public ImageLibrary ImageLibrary => imageLib;

        public string LibraryPath => libraryPath;

        public bool IsLibraryExist()
        {
            return fileManager.IsDirectoryExist(libraryPath);
        }

        public void AddCategory(string category)
        {
            imageLib.AddCategory(category);
        }

        public void RemoveCategory(string category)
        {
            imageLib.RemoveCategory(category);
        }

        public List<string> GetCategories()
        {
            return imageLib.GetCategories();
        }

        public List<CustomImage> GetImageCollection()
        {
            return imageCollection;
        }

        public void RemoveImageFromCollection(CustomImage customImage)
        {
            var modifiedCollection = imageCollection;

            for(int i = 0; i < imageCollection.Count; i++)
            {
                var image = imageCollection[i];
                var removed = image.Id == customImage.Id;
                if (removed)
                {
                    modifiedCollection.Remove(image);
                    i--;
                }
            }

            imageCollection = modifiedCollection;
        }

        public CustomImage GetClosedCardImage()
        {
            return imageLib.GetClosedCardImage();
        }

        public CustomImage GetWinnerImage()
        {
            return imageLib.GetWinnerImage();
        }

        public CustomImage GetMainImage()
        {
            return imageLib.GetMainImage();
        }

        public List<CustomImage> GetImageCollectionByCategory(string category)
        {
            var categorizedCollection = new List<CustomImage>();

            foreach (var customImage in imageCollection)
            {
                if (customImage.Category == category)
                {
                    categorizedCollection.Add(customImage);
                }
            }

            return categorizedCollection;
        }

        public void InitializeLibrary()
        {
            var categories = fileManager.GetSubDirectories(libraryPath);

            foreach (var category in categories)
            {
                var files = fileManager.GetFiles(category);

                foreach (var file in files)
                {
                    FileStream bitmapFile = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    Image image = new Bitmap(bitmapFile);

                    var newImage = new CustomImage
                    {
                        Name = fileManager.GetFileName(file),
                        Category = fileManager.GetDirName(file),
                        Image = image
                    };

                    imageLib.AddImageToLib(newImage);
                    bitmapFile.Close();
                }
            }

            SetMainScreenImage();
            SetWinnerImage();
            SetClosedCardImage();
            InitializeCategories();

            var collection = imageLib.GetCollection();

            for (int i = 0; i < collection.Count; i++)
            {
                this.imageCollection.Add(collection[i]);
                this.imageCollection.Add(collection[i]);
            }
        }

        public void InitializeNewCollection(List<CustomImage> newImageCollection)
        {
            for (int i = 0; i < newImageCollection.Count; i++)
            {
                this.imageCollection.Add(newImageCollection[i]);
            }

            InitializeCategories();
        }

        public void Dispose()
        {
            imageCollection = null;
            imageLib = null;

        }

        private void SetMainScreenImage()
        {
            var mainImage = fileManager.GetFiles(Settings.MainImagePath).FirstOrDefault();
            FileStream bitmapFile = new FileStream(mainImage, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            Image image = new Bitmap(bitmapFile);

            var newCustomImage = new CustomImage
            {
                Name = fileManager.GetFileName(mainImage),
                SpecialName = "MainImage",
                Category = fileManager.GetDirName(mainImage),
                Image = image
            };

            imageLib.SetMainImage(newCustomImage);
            bitmapFile.Close();
        }

        private void InitializeCategories()
        {
            GameState.Categories = imageLib.GetCategories();
        }

        private void SetWinnerImage()
        {
            var winnerImage = fileManager.GetFiles(Settings.WinnerImagePath).FirstOrDefault();
            FileStream bitmapFile = new FileStream(winnerImage, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            Image image = new Bitmap(bitmapFile);

            var newCustomImage = new CustomImage
            {
                Name = fileManager.GetFileName(winnerImage),
                SpecialName = "WinnerImage",
                Category = fileManager.GetDirName(winnerImage),
                Image = image
            };

            imageLib.SetWinnerImage(newCustomImage);
            bitmapFile.Close();
        }

        private void SetClosedCardImage()
        {
            var closedCardImage = fileManager.GetFiles(Settings.ClosedCardImagePath).FirstOrDefault();
            FileStream bitmapFile = new FileStream(closedCardImage, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            Image image = new Bitmap(bitmapFile);

            var newCustomImage = new CustomImage
            {
                Name = fileManager.GetFileName(closedCardImage),
                Category = fileManager.GetDirName(closedCardImage),
                Image = image
            };

            imageLib.SetClosedCardImage(newCustomImage);
            bitmapFile.Close();
        }
    }
}
