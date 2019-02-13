using System;

namespace Assignment_Interface_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Tigger tigger = new Tigger();
            Pigeon pigeon = new Pigeon();
            Penguin penguin = new Penguin();

            IAnimal[] animals = new IAnimal[4];
            animals[0] = cat;
            animals[1] = tigger;
            animals[2] = pigeon;
            animals[3] = penguin;

            foreach (IAnimal animal in animals)
                Console.WriteLine(animal.ToString());

            Zoo zoo = new Zoo();
            zoo.AddAnimal(tigger);
            zoo.AddAnimal(pigeon);
            zoo.AddAnimal(penguin);

            House house = new House();
            house.AddAnimal(cat);

            Console.WriteLine();
            foreach (IAnimal animal in animals)
                Console.WriteLine(animal.ToString());

            pigeon.FlyAway();
            Console.WriteLine();
            Console.WriteLine(pigeon.ToString());

            Console.ReadKey();

        }
    }
}
