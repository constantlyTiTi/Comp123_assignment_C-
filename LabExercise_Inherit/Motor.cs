using System;
namespace LabExercise
{
    public class Motor:Vehicle
    {
        private string name;
        private int cylinders;
        private int bhp;
        private double displacement;

        public Motor(string name,int cylinders, int bhp, double displacement,
                     string make, string model,int year, double price ):
        base(make,model,year,price)
        {
            this.name = name;
            this.cylinders = cylinders;
            this.bhp = bhp;
            this.displacement = displacement;
        }

        public override string ToString()
        {
            //String motorString = base.ToString();
            string motorSpecificPart = string.Format(" Motor Name: {0};\n Cylinder" +
                                                   " : {1};\n bhp: {2};\n " +
                                                   "Displacement: {3};\n",
                                                     name, cylinders,bhp,displacement);
            //motorString += motorSpecificPart;
            return motorSpecificPart;
        }
    }
}
