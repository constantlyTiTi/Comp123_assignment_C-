using System;

namespace LabExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle vehicle = new Vehicle("Vehicle Maker", "Vehcile Model", 2016, 1500);
            Console.WriteLine("Vehicle Example");
            Console.WriteLine(vehicle);
            Console.WriteLine();

            Truck truck = new Truck("Maserati", "MA15901", 2017, 5999.99, "MTC791", 15, 
                                    new Motor("BK001 Motor", 30045, 56007, 223.05,
                                              "BMW Manufactuer","BMW9001",2015,2000.99));

            Console.WriteLine(truck);
            Console.WriteLine();

            PassCar passCar = new PassCar("BMW", "BMW567", 2019, 1299.89, 10, true,
                                        new Motor("EK901", 12890, 23781, 500.99,
                                                  "BMW ELectronic", "EB126", 2019, 3000));
           
            Console.WriteLine(passCar);
            Console.WriteLine();


        }
    }
}
