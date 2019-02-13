using System;
namespace Assignment_Interface_Abstract
{
    public class Zoo : IPlace
    {
        public bool AddAnimal(IAnimal animal)
        {
            animal.Location = Location.zoo;
            return true;
        }
    }
}
