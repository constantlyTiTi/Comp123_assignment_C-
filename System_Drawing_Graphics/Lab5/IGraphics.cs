using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IGraphics : IDisposable //Ting: no idear where this IDisposable come from, 
                                             //      but you have to declare the IGraphics class as public
                                             //      otherwise the other class cannot use it.
    {
        void DrawLine(Pen pen, Point start, Point end);
        void DrawRectangle(Pen pen, Rectangle rectangle);
        void DrawEllipse(Pen pen, Rectangle rectangle);
        void DrawBezier(Pen pen, Point point1, Point point2, Point point3, Point point4);
        void FillRectangle(SolidBrush solidBrush, Rectangle rectangle);
        void FillEllipse(SolidBrush solidBrush, Rectangle rectangle);
    }
}
