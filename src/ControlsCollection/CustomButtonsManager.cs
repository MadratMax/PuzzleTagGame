using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;
using PuzzleTag.FileManager.Library;
using PuzzleTag.Notification;

namespace PuzzleTag.Collection
{
    class CustomButtonsManager
    {
        private ButtonsCollection buttonsCollection;
        private ImageLibraryManager libManager;

        public CustomButtonsManager(ButtonsCollection buttonsCollection, ImageLibraryManager libManager)
        {
            this.buttonsCollection = buttonsCollection;
            this.libManager = libManager;
        }

        public void ResizeButtons(int[] appSize, int coefficient)
        {
            foreach (var button in buttonsCollection.GetAllButtons())
            {
                var width = button.Value.Size.Width + (button.Value.Size.Width * coefficient / 100);
                var height = button.Value.Size.Height + (button.Value.Size.Height * coefficient / 100);
                button.Value.Size = new Size(width, height);
            }
        }

        public void AssignImages(string categoryName)
        {
            var buttons = buttonsCollection.GetAllButtons();
            var categorizedImageCollection = libManager.GetImageCollectionByCategory(categoryName);
            int imageIndex = 0;

            if (categorizedImageCollection != null)
            {
                ValidateAndSet(categorizedImageCollection, categoryName, buttons);
            }
        }

        public void SetClosedCardImages()
        {
            var closedImage = libManager.GetClosedCardImage();
            var buttons = buttonsCollection.GetAllButtons();

            foreach (var button in buttons)
            {
                button.Value.SetClosedCardImage(closedImage.Image);
            }
        }

        public void RefreshButtonImage(CustomButton customButton, CustomImage newImage)
        {
            var buttons = buttonsCollection.GetAllButtons();
            var oldImageId = customButton.ImageId;

            foreach (var button in buttons)
            {
                if (button.Value.ImageId == oldImageId)
                {
                    button.Value.SetImage(newImage.Image);
                    button.Value.ShowImage();
                }
            }
        }

        public void ShowButtonImages()
        {
            var buttons = buttonsCollection.GetAllButtons();

            foreach (var button in buttons)
            {
                button.Value.ShowImage();
            }
        }

        public void HideButtonImages()
        {
            var buttons = buttonsCollection.GetAllButtons();

            foreach (var button in buttons)
            {
                button.Value.HideImage();
                button.Value.ShowClosedCardImage();
            }
        }

        public void RemoveButton(CustomButton button)
        {
            button.Visible = false;
        }

        public ButtonsCollection ButtonsCollection()
        {
            return buttonsCollection;
        }

        public List<CustomButton> GetAllButtons()
        {
            return buttonsCollection.GetAllButtons().Values.ToList();
        }

        public int ExistingButtonsOnBoard()
        {
            return buttonsCollection.GetAllButtons().Count(n => n.Value.Visible);
        }

        private void ValidateAndSet(List<CustomImage> collection, string category, IDictionary<int, CustomButton> buttons)
        {
            if (collection.Count < buttons.Count)
            {
                if (category != null)
                {
                    var message = $"Insufficient images with category {category}";
                    var popUpMessage = new TimedPopUp();
                    popUpMessage.Set(message);
                    popUpMessage.Show(3500);
                }
            }
            else
            {
                foreach (var button in buttons)
                {
                    var customImage = collection[button.Value.Id - 1];
                    button.Value.SetImage(customImage.Image);
                }
            }
        }
    }
}