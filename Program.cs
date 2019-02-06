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

            Customer cus1 = new Customer("kate", "SnowHill M2S3T9", 4671234567);
            Customer cus2 = new Customer("Bill", "Eglington E5W9M3", 6471238900);
            Customer cus3 = new Customer("Mary", "London B1Y5T6", 6471238900);

            Order order1 = cus1.CreateOrder(OrderType.PhoneOrder);
            Order order2 = cus1.CreateOrder(OrderType.RestaurantOrder);
            Order order3 = cus2.CreateOrder(OrderType.PhoneOrder);
            Order order4 = cus3.CreateOrder(OrderType.RestaurantOrder);



            order1.AddOrderItem(oItem1);
            order1.AddOrderItem(oItem2);
            order1.AddOrderItem(oItem3);
            order2.AddOrderItem(oItem1);
            order3.AddOrderItem(oItem3);
            order3.AddOrderItem(oItem4);
            order4.AddOrderItem(oItem3);
            order4.AddOrderItem(oItem2);
            order4.AddOrderItem(oItem1);

            order1.delivered = true;
            order2.delivered = true;
            order3.delivered = false;
            order4.delivered = true;

            //cus1.CreateOrder(order1);
            //cus1.CreateOrder(order2);
            //cus2.CreateOrder(order3);
            //cus3.CreateOrder(order4);

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
