using System;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.DataManager;
using PuzzleTag.FileManager;
using PuzzleTag.Notification;
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
        private Players players;
        private bool isGameStarted;
        private int moveCount;
        private int openCardDelay;

        public Ruler(
            CustomButtonsManager buttonManager, 
            ButtonsCollection buttonCollection, 
            ImageLibraryManager libManager,
            Players players)
        {
            this.buttonManager = buttonManager;
            this.libManager = libManager;
            this.buttonsCollection = buttonCollection;
            this.players = players;
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
            totalScore?.UpdateScore();

            if (currentPlayer != null)
            {
                currentPlayer.AvaButton.FlatAppearance.BorderSize = 0;
                this.currentPlayer = null;
            }
            
            this.scoreStorage = null;
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
                        //UI.Update.UpdateInfoLabel($"{CurrentPlayer.Name.ToUpper()} ходит");
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
            var prev = currentPlayer;
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
                prev.AvaButton.FlatAppearance.BorderSize = 0;

                currentPlayer.AvaButton.FlatAppearance.BorderColor = Color.DarkOrange;
                currentPlayer.AvaButton.FlatAppearance.BorderSize = 4;
            }
            
            ClearMove();
            WaitNextMove = false;
        }

        private void CheckGameStatus()
        {
            if (buttonManager.ExistingButtonsOnBoard() == 0)
            {
                var inGamePlayers = players.GetPlayers().Where(n => n.InGame).ToList();

                //Player first = inGamePlayers[0];
                Player winner = inGamePlayers[0];
                bool drawn = false;

                foreach (var player in inGamePlayers)
                {
                    if (player.DiscoveredCards > winner.DiscoveredCards)
                    {
                        winner = player;
                        drawn = false;
                    }
                    if(player != winner && player.DiscoveredCards == winner.DiscoveredCards)
                    {
                        drawn = true;
                    }
                }

                GameFinished = true;
                StopGame();

                if (!drawn)
                {
                    ShowWinnerScreen(winner);
                }
                else
                {
                    var popUp = new TimedPopUp();
                    popUp.Set("Ничья !");
                    popUp.Show();
                }
            }
        }

        public void ShowWinnerScreen(Player winner)
        {
            var winForm = new WinnerForm();
            var winnerImage = libManager.GetWinnerImage();
            winForm.BackgroundImage = winnerImage?.Image;
            winForm.WinnerAvatar.BackgroundImage = winner.Avatar;
            winForm.WinnerAvatar.BackgroundImageLayout = ImageLayout.Stretch;
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
