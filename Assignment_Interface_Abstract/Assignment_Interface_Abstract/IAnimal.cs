using System;
namespace Assignment_Interface_Abstract
{
    public interface IAnimal
    {
    
        Location Location { get; set; }

        bool IsWild();
        int LegCount();
        string MakeSound();
    }
}
