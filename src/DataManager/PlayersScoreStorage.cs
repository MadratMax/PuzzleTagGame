using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PuzzleTag.Game;
using PuzzleTag.Notification;

namespace PuzzleTag.DataManager
{
    class PlayersScoreStorage
    {
        private List<ScoreModel> playerScoreList;
        private List<Player> players;

        public PlayersScoreStorage()
        {
            this.playerScoreList = new List<ScoreModel>();
            this.players = new List<Player>();
        }

        public void Add(List<Control> controlList, Player player)
        {
            var newScoreModel = new ScoreModel
            {
                Player = player,
                Scores = controlList
            };

            playerScoreList.Add(newScoreModel);
            players.Add(player);
        }

        public ScoreModel GetScoreModel(Player player)
        {
            return playerScoreList.FirstOrDefault(n => n.Player == player);
        }

        public void DisposeScore(Player player)
        {
            if (player != null)
            {
                var scoreModel = playerScoreList?.FirstOrDefault(n => n.Player == player);

                for (int i = 0; i < scoreModel.Scores.Count; i++)
                {
                    UpdateScoreItem(player, i, false);
                }
            }
        }

        public void DisposeData()
        {
            this.playerScoreList.Clear();
            this.players.Clear();
        }

        public void UpdateScoreItem(Player player, int score, bool increaseScore)
        {
            try
            {
                var pl = playerScoreList?.FirstOrDefault(n => n.Player == player);

                if (pl.Scores.Count > score)
                {
                    pl.Scores[score].Visible = increaseScore;
                }
            }
            catch (Exception e)
            {
                var popUpNotification = new TimedPopUp();
                popUpNotification.Set(e.Message);
                popUpNotification.Show();
            }
        }
    }
}
