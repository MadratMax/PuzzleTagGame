using System.Collections.Generic;
using System.Drawing;

namespace PuzzleTag.Game
{
    class TotalScore
    {
        private List<Player> playersInGameList;
        private List<string> totalScoreList;
        private List<Image> prizeList;

        public TotalScore(Players players)
        {
            this.playersInGameList = new List<Player>();
            this.prizeList = new List<Image>();

            foreach (var player in players.GetPlayers())
            {
                if (player.InGame)
                {
                    playersInGameList.Add(player);
                }
            }
        }

        public void UpdateScore(Player currentPlayer = null)
        {
            this.totalScoreList = null;
            this.totalScoreList = new List<string>();

            foreach (var player in playersInGameList)
            {
                 totalScoreList.Add($"{player.Name} : {player.DiscoveredCards}");
                 prizeList.Add(Image.FromFile(@"C:\Users\mgaydideev\Downloads\prize-icon.png"));
                 prizeList.Add(Image.FromFile(@"C:\Users\mgaydideev\Downloads\prize-icon.png"));
            }
        }

        public void ResetScore()
        {
            this.totalScoreList = null;
        }
    }
}
