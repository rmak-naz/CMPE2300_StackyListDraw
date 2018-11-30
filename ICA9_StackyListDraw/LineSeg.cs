using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA9_StackyListDraw
{
    class LineSeg
    {
        public Point GetStart { private set; get; }
        public Point GetEnd { private set; get; }
        public int GetThickness { private set; get; }
        public Color GetColor { private set; get; }

        public LineSeg(Point startPos, Point endPos, int lineThick, Color lineCol)
        {
            GetStart = startPos;
            GetEnd = endPos;
            GetThickness = lineThick;
            GetColor = lineCol;
        }

        public void Render(CDrawer canvas)
        {
            canvas.AddLine(GetStart.X, GetStart.Y, GetEnd.X, GetEnd.Y, GetColor, GetThickness);
        }
    }
}
