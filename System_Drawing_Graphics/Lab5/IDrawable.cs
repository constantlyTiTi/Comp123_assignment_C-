using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IDrawable //Ting: declare as public
    {
        void Draw(IGraphics graphics);
    }
}
