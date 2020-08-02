using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.Painter
{
    interface ITool
    {
        BrushForm Form { get; set; }

        Size Size { get; set; }

        Color Color { get; set; }
    }
}
