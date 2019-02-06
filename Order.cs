using System;
//using System.Collections;
namespace Assignment01
{
    public class Order
    {


        private static int orderIdCounter = 0;
        private int counter = 0;

        public DateTime? DeliverTime { get => Deliver(delivered); }
        public DateTime OrderTime { get; }
        public int CustomerId { get; }
        public string Address { get; set; }
        public OrderItem[] ItemsArray = new OrderItem[50];
        public decimal OrderCost { get { return costCalculation(); } }
        public bool delivered { get; set; }
        public int OrderId { get; }
        public string orderType { get; }

        public Order(Customer objectCus,OrderType objectType)
        {
            orderIdCounter++;
            OrderId = orderIdCounter;
            CustomerId = objectCus.CustomerId;
            orderType = OrderTypeReturn(objectType);
            OrderTime = DateTime.Now;

        }

        public void AddOrderItem(OrderItem item)
        {
            ItemsArray[counter] = item;
            counter++;
        }

        public string OrderTypeReturn(OrderType type)
        {
            string a;
            switch (type)
            {
                case OrderType.PhoneOrder :
                    a = "Phone Order";
                    break;
                default:
                    a = "Restaurant Order";
                    break;
            }
            return a;
        }
        public decimal costCalculation()
        {
            decimal sum = 0;
            for (int i = 0; i <counter;i++)    
            {
                sum += ItemsArray[i].ItemCost;
            }
            return sum;
        }
        public DateTime? Deliver(bool deliverStatus)
        {
            DateTime? varA=null;
            if (deliverStatus == true)
            {
               varA  = DateTime.Now;
            }
            else
            {
                varA = null;
            }
            return varA;
        }

        public void printOrderItem()
        {
            Console.WriteLine("***The Items include***");
            for (int i = 0; i < counter;i++)
            {
                Console.Write("{0}; ",ItemsArray[i].ItemName);
            }
            Console.WriteLine();
        }

        public void GetInfor()
        {

            Console.WriteLine("==========================");
            Console.WriteLine(">>>The order[{0}] is made by customer# {1}", OrderId, CustomerId);
            Console.WriteLine(">>>Cost: {0:C2}", OrderCost);
            Console.WriteLine(">>>The order type is {0};", orderType);
            Console.WriteLine(">>>Ordered at {0}, Delivery at {1}", OrderTime, DeliverTime);
            printOrderItem();
        }
    }
}
