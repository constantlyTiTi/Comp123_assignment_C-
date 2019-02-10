using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem chicken = new MenuItem("Chicken",10m) { Description = "always chicken" };
            MenuItem caviar = new MenuItem("Caviar",8.8m) { Description = "try caviar" };
            MenuItem avocado = new MenuItem("Avocado",3m) { Description = "turning yellow" };
            MenuItem pop = new MenuItem("Pop",1m) { Description = "pep si" };

            OrderItem oItem1 = new OrderItem(chicken);
            OrderItem oItem2 = new OrderItem(caviar);
            OrderItem oItem3 = new OrderItem(avocado);
            OrderItem oItem4 = new OrderItem(pop);

           

            Customer cus1 = new Customer("kate",  new Address("Brimely Road", "E5W9M3" ) , 4671234567);
            Customer cus2 = new Customer("Bill", new Address("Eglington","E5W9M3"), 6471238900);
            Customer cus3 = new Customer("Mary", new Address("London","B1Y5T6"), 6471238900);

            Order order1 = cus1.CreateOrder(OrderType.PhoneOrder, new Address("road information for order 1","ABC"));
            Order order2 = cus1.CreateOrder(OrderType.RestaurantOrder, new Address("road information for order 2", "MT35S9"));
            Order order3 = cus2.CreateOrder(OrderType.PhoneOrder, new Address("road information for order 3", "CCC"));
            Order order4 = cus3.CreateOrder(OrderType.RestaurantOrder, new Address("road information for order 4", "PPPPP"));


            order1.AddOrderItem(oItem1);
            order1.AddOrderItem(oItem2);
            order1.AddOrderItem(oItem3);
            order2.AddOrderItem(oItem1);
            order3.AddOrderItem(oItem3);
            order3.AddOrderItem(oItem4);
            order4.AddOrderItem(oItem3);
            order4.AddOrderItem(oItem2);
            order4.AddOrderItem(oItem1);

            order1.Delivered = true;
            order2.Delivered = true;
            order3.Delivered = false;
            order4.Delivered = true;

            Console.WriteLine("*****************   Menu  ********************");
            Console.WriteLine("||  Item          Cost         Description  ||");
            chicken.GetInfor();
            caviar.GetInfor();
            avocado.GetInfor();
            pop.GetInfor();
            Console.WriteLine("*********  Order details as below  ***********");
            Console.WriteLine();

            cus1.GetInfor();
            cus2.GetInfor();
            cus3.GetInfor();

            order1.GetInfor();
            order2.GetInfor();
            order3.GetInfor();
            order4.GetInfor();

            Console.ReadKey();
        }

    }
}
