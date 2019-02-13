using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Feline:Animal
    {
        private int FelineLeg;

        public Feline()
        {
            FelineLeg=4;
        }

        public override int LegCount()
        {
            return FelineLeg;
        }

    }
}
