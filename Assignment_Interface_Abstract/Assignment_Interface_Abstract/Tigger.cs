using System;
namespace Assignment_Interface_Abstract
{
    public class Tigger:Feline
    {
        public Tigger():base("Tigger")
        {
            this.LegCount();
           //this.ToString(); reducdance
        }

        public override bool IsWild()
        {
            bool checkWild = true;
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
            return "Roar";
        }
    }
}
