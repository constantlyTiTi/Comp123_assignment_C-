using System;

namespace Assignment01
{
    public class MenuItem
    {
        //private string name;
        public string Description { get; set; }
        public decimal BaseCost { get; }
        public string Name { get; }
        public MenuItem(string name, decimal cost)
        {
            Name = name;
            BaseCost = cost;
        }
        public void GetInfor()
        {
            Console.Write("||{0,8}", Name);
            Console.Write("{0,13:C2}", BaseCost);
            Console.Write("{0,20} ||", Description);
            Console.WriteLine();
        }
    }
}
