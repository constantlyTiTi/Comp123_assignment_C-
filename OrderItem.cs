using System;
namespace Assignment01
{
    public class OrderItem
    {
        public string ItemName { get; }
        public decimal ItemCost { get; }

        public OrderItem(MenuItem a)
        {
            ItemName = a.Name;
            ItemCost = a.BaseCost;
            
        }

        //public void GetInfor()
        //{
        //    Console.WriteLine("*****Item Name********");
        //    Console.WriteLine("{0}: {1:C2}",ItemName,ItemCost);
        //}
    }
}
