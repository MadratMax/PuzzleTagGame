using System;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.DataManager;
using PuzzleTag.FileManager;
using PuzzleTag.UI;

namespace PuzzleTag.Game
{
    class Ruler
    {
        private CustomButtonsManager buttonManager;
        private ImageLibraryManager libManager;
        private ButtonsCollection buttonsCollection;
        private MoveQueue moveQueue;
        private TotalScore totalScore;
        private PlayersScoreStorage scoreStorage;
        private Player currentPlayer;
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

        public bool IsGameStarted;

        public void StartGame(MoveQueue moveQueue, TotalScore totalScore, PlayersScoreStorage scoreStorage)
        {
            IsGameStarted = true;
            this.scoreStorage = scoreStorage;
            this.moveQueue = moveQueue;
            this.currentPlayer = this.moveQueue.NextPlayer();
            this.totalScore?.ResetScore();
            this.totalScore = totalScore;
            GameFinished = false;
        }

        public void StopGame()
        {
            IsGameStarted = false;
            totalScore.UpdateScore();
            this.currentPlayer = null;
            this.scoreStorage = null;
            UI.Update.ClearInfoLabel();
        }

        public Player CurrentPlayer => currentPlayer;

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
                        var successMove = Result();
                        UI.Update.UpdateInfoLabel($"{CurrentPlayer.Name.ToUpper()} ходит");
                        UpdateScore();
                        DelayAndClose(successMove);
                    }
                }
            }
        }

        private void UpdateScore()
        {
            totalScore.UpdateScore(CurrentPlayer);
        }

        public void CloseCard(CustomButton button)
        {
            button.ShowClosedCardImage();
        }

        private void ClearMove()
        {
            CurrentCard = null;
            FirstCard = null;
            SecondCard = null;
        }

        private async void DelayAndClose(bool isSuccessMove)
        {
            WaitNextMove = true;
            currentPlayer = this.moveQueue.NextPlayer();
            await Task.Delay(openCardDelay);

            if (isSuccessMove)
            {
                buttonManager.RemoveButton(FirstCard);
                buttonManager.RemoveButton(SecondCard);
                CheckGameStatus();
            }
            else
            {
                CloseCard(FirstCard);
                CloseCard(SecondCard);
            }

            if (!GameFinished)
            {
                UI.Update.UpdateInfoLabel($"{CurrentPlayer?.Name.ToUpper()} ходит");
            }
            
            ClearMove();
            WaitNextMove = false;
        }

        private void CheckGameStatus()
        {
            if (buttonManager.ExistingButtonsOnBoard() == 0)
            {
                GameFinished = true;
                StopGame();
                ShowWinnerScreen();
            }
        }

        private void ShowWinnerScreen()
        {
            var winForm = new WinnerForm();
            var winnerImage = libManager.GetImageCollection().FirstOrDefault(n => n.SpecialName == "WinnerImage");
            winForm.BackgroundImage = winnerImage?.Image;
            winForm.ShowDialog();
        }

        private bool Result()
        {
            if (FirstCard.Image == SecondCard.Image)
            {
                currentPlayer.DiscoveredCards++;
                scoreStorage.UpdateScoreItem(currentPlayer, currentPlayer.DiscoveredCards-1, true);
                return true;
            }

            return false;
        }

        private CustomButton CurrentCard;

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

        private bool GameFinished;
    }
}
