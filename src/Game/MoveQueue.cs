using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.Game
{
    class MoveQueue
    {
        private Players players;
        private List<Player> playersList;
        private List<Player> playersInGameList;
        private int currentIndex;
        private int max;

        public MoveQueue(Players players)
        {
            this.players = players;
            this.playersList = this.players.GetPlayers();
            this.playersInGameList = new List<Player>();

            foreach (var player in playersList)
            {
                if (player.InGame)
                {
                    playersInGameList.Add(player);
                }
            }

            max = this.playersInGameList.Count;
            currentIndex = 1;
        }

        public Player NextPlayer()
        {
            return Queue().Next;
        }

        public Player CurrentPlayer()
        {
            return Queue().Prev;
        }

        private MoveQueue Queue()
        {
            if (currentIndex > max)
            {
                currentIndex = 1;
            }

            Prev = Next;
            Next = playersInGameList.FirstOrDefault(n => n.Index == currentIndex) ?? playersInGameList.FirstOrDefault(n => n.Index == currentIndex+1);
            currentIndex++;

            return this;
        }
        
        private Player Prev;

        private Player Next;
    }
}
