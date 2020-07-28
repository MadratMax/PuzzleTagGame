using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleTag.Game;

namespace PuzzleTag.Configuration
{
    class GameState
    {
        public static List<string> Categories;

        public static string Category;

        public static int PlayersCount;

        public static List<Player> Players;

        public static List<Player> PlayersInGame = new List<Player>(3);

        public static Player Player1;

        public static Player Player2;

        public static Player Player3;

        public static MoveQueue MoveQueue;

        public static Player CurrentPlayer;
    }
}
