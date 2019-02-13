using System;
namespace Assignment_Interface_Abstract
{
    public class Cat:Feline
    {
        public Cat()
        {
            this.Name = "cat";
            this.LegCount();
            this.ToString();
        }
        public override bool IsWild()
        {
            bool checkWild=true;
            if (this.Location == Location.Wild)
            {
                checkWild = true;
            }
            else
            {
                checkWild = false;
            }

           return checkWild;
        }
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
