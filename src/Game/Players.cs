using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PuzzleTag.Game
{
    class Players
    {
        private List<Player> players;
        private int playerIndex = 1;

        public Players()
        {
            this.players = new List<Player>();
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public List<string> GetPlayerNames()
        {
            return players.Select(n => n.Name).ToList();
        }

        public void AddPlayer(string name, string avatar)
        {
            Image avaImage = null;

            if (File.Exists(avatar))
            {
                avaImage = Image.FromFile(avatar);
            }

            var newPlayer = new Player
            {
                Name = name,
                Avatar = avaImage
            };

            players.Add(newPlayer);
        }

        public Player GetPlayerByName(string name)
        {
            return players.FirstOrDefault(n => n.Name == name);
        }

        public Player GetPlayerByIndex(int index)
        {
            return players.FirstOrDefault(n => n.Index.Equals(index));
        }

        public bool IsPlayerMove(string name)
        {
            return players.FirstOrDefault(n => n.Name == name).IsMoving;
        }

        public void AddPlayerToGame(Player player, int index)
        {
            if (player != null)
            {
                players.FirstOrDefault(n => n == player).InGame = true;
                players.FirstOrDefault(n => n == player).Index = index;
            }
        }

        public void RemovePlayerFromGame(Player player)
        {
            if (player != null)
            {
                players.FirstOrDefault(n => n == player).InGame = false;
                players.FirstOrDefault(n => n == player).Index = 0;
            }
        }

        public void RemovePlayersFromGame()
        {
            foreach (var player in players)
            {
                player.InGame = false;
                player.Index = 0;
            }
        }
    }
}
