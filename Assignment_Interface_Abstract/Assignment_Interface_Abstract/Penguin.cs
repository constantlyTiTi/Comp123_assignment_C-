using System;
namespace Assignment_Interface_Abstract
{
    public class Penguin:Bird
    {
    
        public Penguin()
        {
            // "Penguin"; 
            this.LegCount();
            this.Name = "Penguin";
            this.ToString();
        }

        public override string MakeSound()
        {
            return "Honk";
        }
        public override bool IsWild()
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
