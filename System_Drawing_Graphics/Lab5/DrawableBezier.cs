﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DrawableBezier: IDrawable
    {
        Color _color; 
        Point _curveStart;
        Point _controlFirst;
        Point _controlSecond;
        Point _curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            _color =color;
            _curveStart = start;
            _controlFirst = first;
            _controlSecond = second;
            _curveEnd = end;
        }
        public void Draw(IGraphics graphics)//Ting: it seems to be inherient from interface 
        {
            graphics.DrawBezier(new Pen(_color), _curveStart, _curveStart, _controlSecond, _curveEnd);

        }
    }
}
