using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class GraphicsWrapper : IGraphics
    {
        private Graphics _graphics;

        public GraphicsWrapper(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void DrawLine(Pen pen, Point start, Point end) //if this DrawLine is inherited from Igraphics class
                                                              // that means both of these two method have to follow same format
                                                              // so I add the arguments to your Igraphic class
        {
            _graphics.DrawLine(pen, start, end);
        }

        public void DrawRectangle(Pen pen, Rectangle rectangle)
        {
            _graphics.DrawRectangle(pen, rectangle);
        }
        public void DrawEllipse(Pen pen, Rectangle rectangle)
        {
            _graphics.DrawEllipse(pen, rectangle);
        }
        public void DrawBezier(Pen pen, Point point1, Point point2, Point point3, Point point4)
        {
            _graphics.DrawBezier(pen, point1, point2, point3, point4);
        }
        public void FillRectangle(SolidBrush solidBrush, Rectangle rectangle)
        {
            _graphics.FillRectangle(solidBrush, rectangle);
        }
        public void FillEllipse(SolidBrush solidBrush, Rectangle rectangle)
        {
            _graphics.FillEllipse(solidBrush, rectangle);
        }
        public void Dispose()
        {
            _graphics.Dispose();
        }

        //public void DrawLine()
        //{
        //    throw new NotImplementedException();
        //}
    }
}