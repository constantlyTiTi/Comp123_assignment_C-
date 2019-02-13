using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Animal :IAnimal
    {
        private string name;
        private Location location;

        public Location Location 
        {
            get { return location; }
            set { location = value; }
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

       public Animal()
        {

        }
        public abstract bool IsWild();
        public abstract int LegCount();
        public abstract string MakeSound();

        public override string ToString()
        {
            string outPut;
            string place;
            if (this.IsWild()==true)
            {
                place = "Wild";
            }
            else
            {
                if (this.location==Location.House)
                {
                    place = "House";
                }
                else
                {
                    place = "Zoo";
                }
            }



            outPut = string.Format("The {0} goes {1} in the {2}", 
                                   name, MakeSound(),place);
          

            return outPut;
        }
    }
}
