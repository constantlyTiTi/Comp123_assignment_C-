using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Bird :Animal
    {

        public Bird(string name)
        {
            Name=name;
        }
        public override int LegCount()
        {
            return 2;
        }
    }
}
