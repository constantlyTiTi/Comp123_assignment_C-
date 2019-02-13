﻿using System;
namespace Assignment_Interface_Abstract
{
    public class Pigeon : Bird, IFlight
    {
        public Pigeon()
        {
            this.Name = "Pigeon";
            this.LegCount();
            this.ToString();
        }

        public void FlyAway()
        {
            this.Location = Location.Wild;
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
            return "coo";
        }
    }
}
