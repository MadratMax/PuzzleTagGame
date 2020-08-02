using System.Drawing;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace PuzzleTag.Painter
{
    class Brush : ITool
    {
        public BrushForm Form { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; }
    }
}
