using System;
namespace LabExercise
{
    public class Truck:Vehicle
    {
        private string type;
        private int capacity;
        private Motor motor;

        public Truck(string make,string model,int year, double price,
                     string type,int capacity, Motor motor):base(make,model,year,price)
       {
            this.type = type;
            this.capacity = capacity;
            this.motor = motor;
       }

        public override void Description()
        {
            Console.WriteLine("Type of this truck is {0}", type);
            Console.WriteLine("The capacity of this truck is {0}", capacity);
            Console.WriteLine("The motor of this truck is {0}", motor);
        }
        public override string ToString()
        {
            return string.Format("======= Truck =======\n Type: {0};\n Capacity:" +
                                 " {1}T;\n ***** Motor *****\n{2} " +
                                 "Made in: {3};\n Model: {4};\n Price: {5:C2};",
                                 type, capacity, motor, Make,Model,Price);
        }
    }
}
