using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Feline:Animal
    {
        private const int felineLeg=4;

        public Feline(string name):base(name)
        {
        }
       

        public override int LegCount()
        {
            return felineLeg;
        }

    }
}
