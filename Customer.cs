using System;
namespace Assignment01
{
    public class Customer
    {
        private string address;
        private long telephoneNum;
        private string name;
        private int counter = 0;
        private string orderaddress;

        public static int CustomerIdStatic = 0;
        public Order[] OrdersArray = new Order[50];
        public int CustomerId { get; }

        public Customer(string name, string address, long telephoneNum)
        {
            CustomerIdStatic++;
            CustomerId = CustomerIdStatic;
            this.name = name;
            this.address = address;
            this.telephoneNum = telephoneNum;
        }

        #region method
        public Order CreateOrder(OrderType typeName, string addOrder)
        {
            orderaddress = addOrder;
            Order orderCreate = new Order(this.CustomerId, typeName, orderaddress);
            OrdersArray[counter] = orderCreate;
            ++counter;
            return orderCreate;
        }
        public void printOrderArray()
        {

            Console.WriteLine("******Order******");
            for (int i = 0; i < counter;i++)
            {
                Console.Write("{0}; ", OrdersArray[i].OrderId);
            }
            Console.WriteLine();
        }
        public void GetInfor()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("The customer ID is {0};", CustomerId);
            Console.WriteLine("Customer Name is {0}", name);
            Console.WriteLine("Telephone No. is [{0}]", telephoneNum);
            Console.WriteLine("Address: {0};", address);
            printOrderArray();

        }
        #endregion
    }
}
