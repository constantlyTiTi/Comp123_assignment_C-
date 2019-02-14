using System;
namespace Assignment_Interface_Abstract
{
    public abstract class Animal :IAnimal
    {
       // private string name;
        //private Location location;

        public Location Location 
        {
            get;
            set;
        }
        public string Name 
        { 
            get;
        }

       public  Animal(string name)
        {
            Name=name;
        }
        public abstract bool IsWild();
        public abstract int LegCount();
        public abstract string MakeSound();

        public override string ToString()
        {
            #region delete
            // string outPut;
            // string place;
            // if (this.IsWild()==true)
            // {
            //     place = "Wild";
            // }
            // else
            // {
            //     if (this.location==Location.House)
            //     {
            //         place = "House";
            //     }
            //     else
            //     {
            //         place = "Zoo";
            //     }
            // }

#endregion

            return string.Format("The {0} goes {1} in the {2}", 
                                   Name, MakeSound(),Location);
          
        }
    }
}
