using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DrawableRectangle : Primitive, IDrawable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle):base(color,filled,rectangle) //refer to drawableEllipse class
        {
            _color = color;
            _filled = filled;
            _boundingRectangle = rectangle;
        }
        public void Draw(IGraphics graphics) //if you have public youd better remove Idrawable otherwise there will be error.
                                                // I dont understand why some of the codes have public, but no public here
        {

            if (_filled==true)
            {
                graphics.FillRectangle(new SolidBrush(_color), _boundingRectangle);
            }
            else
            {
                graphics.DrawRectangle(new Pen(_color), _boundingRectangle);
            }

        }
    }
}
