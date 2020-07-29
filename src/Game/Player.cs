using System.Drawing;
using System.Windows.Forms;

namespace PuzzleTag.Game
{
    class Player
    {
        public string Name;

        public int Index;

        public bool InGame;

        public bool IsMoving;

        public int Steps;

        public Image Avatar;

        public Button AvaButton;

        public int DiscoveredCards;
    }
}
