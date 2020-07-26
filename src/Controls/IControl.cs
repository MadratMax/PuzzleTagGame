using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.Controls
{
    interface IControl
    {
        bool Enabled { get; set; }

        bool Visible { get; set; }

        string Text { get; set; }

        Size Size { get; set; }

        string GetName();

        void SetName(string name);

        void Click();

        void HideImage();

        void ShowImage();

        void SetImage(Image image);
    }
}
