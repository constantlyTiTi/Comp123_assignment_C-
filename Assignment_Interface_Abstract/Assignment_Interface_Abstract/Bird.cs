using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Bird :Animal
    {
        private int birdLeg;

        public Bird()
        {
            birdLeg = 2;
        }
        public override int LegCount()
        {
            return birdLeg;
        }
    }
}
