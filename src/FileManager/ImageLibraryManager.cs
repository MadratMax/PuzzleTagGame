using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
            this.libraryPath = Settings.LibraryPath;
            this.winnerImagePath = Settings.WinnerImagePath;
            this.closedCardImagePath = Settings.ClosedCardImagePath;
            this.fileManager = new FileManager();
            this.imageLib = new ImageLibrary();
        }

        public bool IsLibraryExist()
        {
            return fileManager.IsDirectoryExist(libraryPath);
        }

        public List<CustomImage> GetImageCollection()
        {
            return imageCollection;
        }

        public CustomImage GetClosedCardImage()
        {
            return imageLib.GetClosedCardImage();
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
                    var newImage = new CustomImage
                    {
                        Name = fileManager.GetFileName(file),
                        Category = fileManager.GetDirName(file),
                        Image = Image.FromFile(file)
                    };

                    imageLib.AddImageToLib(newImage);
                }
            }

            SetWinnerImage();
            SetClosedCardImage();
            InitializeCategories();

            this.imageCollection = imageLib.GetCollection();
        }

        private void InitializeCategories()
        {
            GameState.Categories = imageLib.GetCategories();
        }

        private void SetWinnerImage()
        {
            var winnerImage = fileManager.GetFiles(Settings.WinnerImagePath).FirstOrDefault();
            var newCustomImage = new CustomImage
            {
                Name = fileManager.GetFileName(winnerImage),
                Category = fileManager.GetDirName(winnerImage),
                Image = Image.FromFile(winnerImage)
            };

            imageLib.SetWinnerImage(newCustomImage);
        }

        private void SetClosedCardImage()
        {
            var closedCardImage = fileManager.GetFiles(Settings.ClosedCardImagePath).FirstOrDefault();
            var newCustomImage = new CustomImage
            {
                Name = fileManager.GetFileName(closedCardImage),
                Category = fileManager.GetDirName(closedCardImage),
                Image = Image.FromFile(closedCardImage)
            };

            imageLib.SetClosedCardImage(newCustomImage);
        }
    }
}
