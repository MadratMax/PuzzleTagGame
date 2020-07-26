using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleTag.Generators
{
    class ButtonGenerator
    {
        private List<Button> buttons;

        public ButtonGenerator()
        {
            this.buttons = new List<Button>();
        }

        public void GenerateButtons(int count, int height, int width, int x, int y)
        {
            for (int i = 0; i < count; i++)
            {
                var button = new Button();
                button.Height = height;
                button.Width = width;
                button.Location = new Point(x, y);
                this.buttons.Add(button);
            }
        }

        public List<Button> GetButtons()
        {
            return this.buttons;
        }
    }
}
