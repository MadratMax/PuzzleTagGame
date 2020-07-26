using System;
using System.Threading.Tasks;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;

namespace PuzzleTag.Game
{
    class Ruler
    {
        private CustomButtonsManager buttonManager;
        private ImageLibraryManager libManager;
        private ButtonsCollection buttonsCollection;
        private bool isGameStarted;
        private int moveCount;
        private int openCardDelay;

        public Ruler(
            CustomButtonsManager buttonManager, 
            ButtonsCollection buttonCollectio, 
            ImageLibraryManager libManager)
        {
            this.buttonManager = buttonManager;
            this.libManager = libManager;
            this.buttonsCollection = buttonCollectio;
            openCardDelay = Convert.ToInt32(Settings.Delay) * 1000;
        }

        public void StartGame()
        {
            IsGameStarted = true;
        }

        public bool RoundWin;

        public void OpenCard(string buttonName)
        {
            var nextCard = buttonsCollection.GetCustomButtonByName(buttonName);

            if (!WaitNextMove && nextCard != FirstCard)
            {
                RoundWin = false;

                CurrentCard = buttonsCollection.GetCustomButtonByName(buttonName);

                MovesCount++;

                if (MovesCount > 1)
                {
                    SecondCard = CurrentCard;
                }
                else
                {
                    FirstCard = CurrentCard;
                }

                if (IsGameStarted && CurrentCard.Closed)
                {
                    CurrentCard.ShowImage();

                    if (MovesCount == 2)
                    {
                        WaitNextMove = true;
                        DelayAndClose();
                    }
                }
            }
        }

        private void ClearMove()
        {
            CurrentCard = null;
            FirstCard = null;
            SecondCard = null;
        }

        public void CloseCard(CustomButton button)
        {
            button.ShowClosedCardImage();
        }

        private async void DelayAndClose()
        {
            WaitNextMove = true;
            await Task.Delay(openCardDelay);
            Result();
            CloseCard(FirstCard);
            CloseCard(SecondCard);
            ClearMove();
            WaitNextMove = false;
        }

        private void Result()
        {
            if (FirstCard.Image == SecondCard.Image)
            {
                buttonManager.RemoveButton(FirstCard);
                buttonManager.RemoveButton(SecondCard);

                RoundWin = true;
            }

            RoundWin = false;
        }

        private CustomButton CurrentCard;

        private bool IsGameStarted;

        private int MovesCount
        {
            get
            {
                return moveCount;
            }
            set
            {
                if (moveCount == 2)
                {
                    moveCount = 1;
                }
                else
                {
                    moveCount = value;
                }
            }
        }

        private CustomButton FirstCard;

        private CustomButton SecondCard;

        private bool WaitNextMove;
    }
}
