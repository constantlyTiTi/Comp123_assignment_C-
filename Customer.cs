using System;
namespace Assignment01
{
    public class Customer
    {
        private string address;
        private long telephoneNum;
        private string name;
        private int counter = 0;
        private int customerId { get; }
        private  Order[] ordersArray = new Order[50];

        public static int CustomerIdStatic = 0;
        public Order[] OrdersArray { get { return ordersArray; }}
        public int CustomerId{get { return customerId; }}

       

        private Customer()
        {
            CustomerIdStatic++;
            customerId = CustomerIdStatic;
        }
        public Customer(string name, Address address, long telephoneNum):this()
        {

            this.name = name;
            this.address = string.Format("{0}, {1}",address.RoadInfor,address.AddressEmail);
            this.telephoneNum = telephoneNum;
        }

        #region method
        public Order CreateOrder(OrderType typeName, Address address)
        {
            Order orderCreate = new Order(this.customerId, typeName, address);
            ordersArray[counter] = orderCreate;
            ++counter;
            return orderCreate;
        }
        public void printOrderArray()
        {

            Console.WriteLine("******Order******");
            for (int i = 0; i < counter;i++)
            {
                Console.Write("{0}; ", ordersArray[i].OrderId);
            }
            Console.WriteLine();
        }
        public void GetInfor()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("The customer ID is {0};", customerId);
            Console.WriteLine("Customer Name is {0}", name);
            Console.WriteLine("Telephone No. is [{0}]", telephoneNum);
            Console.WriteLine("Address: {0};", address);
            printOrderArray();

        }
        #endregion
    }
}
