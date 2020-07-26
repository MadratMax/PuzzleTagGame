using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.Collection
{
    class CustomButtonsManager
    {
        private ButtonsCollection buttonsCollection;

        public CustomButtonsManager(ButtonsCollection buttonsCollection)
        {
            this.buttonsCollection = buttonsCollection;
        }

        public void ResizeButtons(int[] appSize, int coefficient)
        {
            foreach (var button in buttonsCollection.GetAllButtons())
            {
                var width = button.Value.Size.Width + (button.Value.Size.Width * coefficient / 100);
                var height = button.Value.Size.Height + (button.Value.Size.Height * coefficient / 100);
                button.Value.Size = new Size(width, height);
            }
        }
    }
}
