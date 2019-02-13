using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Feline:Animal
    {
        private int felineLeg;

        public Feline()
        {
            felineLeg=4;
        }

        public override int LegCount()
        {
            return felineLeg;
        }

    }
}
