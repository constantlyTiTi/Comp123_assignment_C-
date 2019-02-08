using System;
namespace Assignment01
{
    public class OrderItem
    {
        private string itemName;
        private decimal itemCost;

        public string ItemName { get { return itemName; } }
        public decimal ItemCost { get { return itemCost; } }

        public OrderItem(MenuItem a)
        {
            itemName = a.Name;
            itemCost = a.BaseCost;
            
        }

        //public void GetInfor()
        //{
        //    Console.WriteLine("*****Item Name********");
        //    Console.WriteLine("{0}: {1:C2}",ItemName,ItemCost);
        //}
    }
}
