using System;
namespace LabExercise
{
    public class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make 
        { 
            get { return make; }
        }
        public string Model
        {
            get { return model; }
        }
        public int Year
        {
            get { return year; }
        }
        protected double Price
        {
            get { return price; }
        }

        public Vehicle(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Description()
        {
            Console.WriteLine("this vehicle is made in {0}", year);
            Console.WriteLine("this price is {0:C2}", price);
            Console.WriteLine("this model is made {0}", model);
            Console.WriteLine("The manufacture is {0}", make);
        }
        public override string ToString()
        {

            return string.Format(" This vehicle is made in {0}, manufacture is {1}" +
                                 "model is {2}, price is {3:C2}",year,make,model
                                 ,price);
        }
    }
}
