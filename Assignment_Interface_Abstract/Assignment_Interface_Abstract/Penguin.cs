using System;
namespace Assignment_Interface_Abstract
{
    public class Penguin:Bird
    {
    
        public Penguin():base ("Penguin")
        {
            // "Penguin"; 
            this.LegCount();
            //this.ToString(); reducdance
        }

        public override string MakeSound()
        {
            return "Honk";
        }
        public override bool IsWild() //this could be written in father class, but assignment asks for this
        {
            bool checkPlace = true;
            if (this.Location == Location.Wild)
            {
                checkPlace = true;
            }
            else
            {
                checkPlace = false;
            }
            return checkPlace;
        }
    }
}
