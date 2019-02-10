using System;

namespace Assignment01
{
    public class MenuItem
    {
        //private string name;
        private string description;
        private decimal baseCost;
        private string name;

        public string Description { get { return description; } 
                                    set { description = value; } }
        public decimal BaseCost { get { return baseCost; } }
        public string Name { get { return name; }}

        public MenuItem(string name,decimal cost)
        {
            this.name = name;
            baseCost = cost;
        }
        public void GetInfor()
        {
            Console.Write("||{0,8}", name);
            Console.Write("{0,13:C2}", baseCost);
            Console.Write("{0,20} ||", description);
            Console.WriteLine();
        }
    }
}
