using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DrawableEllipse : Primitive, IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle):base(color,filled, rectangle)
                                                                        // as the constructor is inherited from a base class
                                                                        // you have to use constructor like this
        {
            _color = color;
            _filled = filled;
            _boundingRectangle = rectangle;
        }

        public void Draw(IGraphics graphics) //Ting: as this is the method inherited from interface class you have to 
                                            // give it a body if it is not an abstract method;
                                            //      and you dont need to use Idrawable.Draw() here as it could be 
                                           //      inherited from IDrawable class
        {
            Pen pen = new Pen(_color);
            if (_filled==true)
            graphics.DrawEllipse(pen, _boundingRectangle);
        }
    }
}
