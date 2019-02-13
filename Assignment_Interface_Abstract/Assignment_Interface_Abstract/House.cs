using System;
namespace Assignment_Interface_Abstract
{
    public class House : IPlace
    {
        public bool AddAnimal(IAnimal animal)
        {
            animal.Location = Location.House;
            return false;
        }
    }
}
