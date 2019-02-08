using System;
//using System.Collections;
namespace Assignment01
{
    public class Order
    {


        private static int orderIdCounter = 0;
        private int counter = 0;

        private DateTime? deliverTime { get => Deliver(delivered); }
        private DateTime orderTime { get; }
        private int customerId { get; }
        private string address { get; set; }
        private OrderItem[] itemsArray = new OrderItem[50];
        private decimal orderCost { get { return costCalculation(); } }
        private bool delivered;
        private int orderId { get; }
        private string orderType { get; }

        public int OrderId { get { return orderId; } }
        public bool Delivered { get { return delivered; } 
                                set { delivered = value; } }

        #region delete
        //public DateTime? DeliverTime { get { return deliverTime; } }
        //public DateTime OrderTime { get { return orderTime; } }
        //public int CustomerId { get { return customerId; } }
        //public string Address { get { return address; } }
        //public OrderItem[] ItemsArray { get { return itemsArray; }}
        //public decimal OrderCost { get { return orderCost; } }

        //public string OrderType { get { return orderType; }}
        #endregion

        private Order()
        {
            orderIdCounter++;
            orderId = orderIdCounter;
            orderTime = DateTime.Now;
        }

        public Order(int cusId, OrderType objectType, Address address):this()
        {

            customerId = cusId;
            orderType = OrderTypeReturn(objectType);

            this.address = string.Format("{0}, {1}", address.RoadInfor, address.AddressEmail); ;

        }

        public void AddOrderItem(OrderItem item)
        {
            itemsArray[counter] = item;
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
                sum += itemsArray[i].ItemCost;
            }
            return sum;
        }
        public DateTime? Deliver(bool delivered)
        {
            DateTime? varA=null;
            if (delivered == true)
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
                Console.Write("{0}; ",itemsArray[i].ItemName);
            }
            Console.WriteLine();
        }

        public void GetInfor()
        {

            Console.WriteLine("==========================");
            Console.WriteLine(">>>The order[{0}] is made by customer# {1}", orderId, customerId);
            Console.WriteLine(">>>Cost: {0:C2}", orderCost);
            Console.WriteLine(">>>The order type is {0};", orderType);
            Console.WriteLine(">>>Order deliver address is {0};", address);
            Console.WriteLine(">>>Ordered at {0}, Delivery at {1}", orderTime, deliverTime);
            printOrderItem();
        }
    }
}
