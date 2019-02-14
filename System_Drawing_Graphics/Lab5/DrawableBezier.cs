using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DrawableBezier: IDrawable
    {
        Pen _color; // Ting: feel this should be pen
        Point _curveStart;
        Point _controlFirst;
        Point _controlSecond;
        Point _curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            _color =new Pen(color);
            _curveStart = start;
            _controlFirst = first;
            _controlSecond = second;
            _curveEnd = end;
        }
        public void Draw(IGraphics graphics)//Ting: it seems to be inherient from interface 
        {
            graphics.DrawBezier(_color, _curveStart, _curveStart, _controlSecond, _curveEnd);

        }
    }
}
