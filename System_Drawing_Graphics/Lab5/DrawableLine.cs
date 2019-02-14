using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class DrawableLine : IDrawable
    {
        Color _color;
        Point _lineStart;
        Point _lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            _color = color;
            _lineStart = start;
            _lineEnd = end;
        }
        public void Draw(IGraphics graphics)//Ting: this is the child class of interface, so you have to give it a body
        {
            Pen pen = new Pen(_color);
            graphics.DrawLine(pen, _lineStart, _lineEnd);
        }
    }
}
