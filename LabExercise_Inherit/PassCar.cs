using System;
namespace LabExercise
{
    public class PassCar:Vehicle
    {
        private int numPass;
        private Boolean ac;
        private Motor motor;

        public PassCar(string make, string model,int year, double price, 
                       int numPass,Boolean ac,Motor motor):base(make,model,year,price)
        {
            this.numPass = numPass;
            this.ac = ac;
            this.motor = motor;
        }
        public override void Description()
        {
            Console.WriteLine("NumPass of this PassCar is {0}", numPass);
            Console.WriteLine("The ac of this PassCar is {0}", ac);
            Console.WriteLine("The motor of this PassCar is {0}", motor);
        }
        public override string ToString()
        {
            return string.Format("======= PassCar =======\n NumPass: {0};\n " +
                                 "AC: {1};\n ****** Motor ******\n{2}" +
                                 " Made in: {3};\n Model: {4};\n Price: {5};",
                                 numPass, ac, motor, Make, Model, Price);
        }
    }
}
