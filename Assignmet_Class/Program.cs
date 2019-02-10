using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string addressRoad;
            string mailboxAddress;
            long teleNumber;
            int customerCounter = 0;
            int orderCounter = 0;
          
            string orderItemChoose;
            string orderChooseAnother;
            string orderPrintCheck;
            string orderDeliveryCheck;
            Customer[] customerArray = new Customer[50];
            Order [] orderCreate = new Order[50];
            string orderMakeCheck;
            string orderTypeEnter;
            string orderRoadAddress;
            string orderMailBoxAddress;
            OrderType orderType=new OrderType();


            MenuItem chicken = new MenuItem("Chicken", 10m) { Description = "always chicken" };
            MenuItem caviar = new MenuItem("Caviar", 8.8m) { Description = "try caviar" };
            MenuItem avocado = new MenuItem("Avocado", 3m) { Description = "turning yellow" };
            MenuItem pop = new MenuItem("Pop", 1m) { Description = "pep si" };

            OrderItem oItem1 = new OrderItem(chicken);
            OrderItem oItem2 = new OrderItem(caviar);
            OrderItem oItem3 = new OrderItem(avocado);
            OrderItem oItem4 = new OrderItem(pop);

            Console.WriteLine("New customer? y/n");
            string newcustomercheck = Console.ReadLine();

            for (; newcustomercheck.ToLower() != "n";)
            {
                customerCounter++;

                Console.WriteLine("pls Enter you name: ");
                name = Console.ReadLine();
                Console.WriteLine("pls Enter your address road: ");
                addressRoad = Console.ReadLine();
                Console.WriteLine("pls Enter your mail-box address");
                mailboxAddress = Console.ReadLine();
                Console.WriteLine("Pls enter your telephone number: ");
                teleNumber = Convert.ToInt32(Console.ReadLine());

                customerArray[customerCounter-1] = new Customer(name, new Address(addressRoad, mailboxAddress), teleNumber);
                Console.WriteLine("your customer Id is [{0}]", customerArray[customerCounter-1].CustomerId);

                Console.WriteLine("Do you want to create order? y/n");
                orderMakeCheck = Console.ReadLine().ToLower();
                for (; orderMakeCheck == "y";)
                {
                    orderCounter++;
                    Console.WriteLine("what is the order type: online/instore");
                    orderTypeEnter = Console.ReadLine().ToLower();
                    Console.WriteLine("pls Enter your order address road: ");
                    orderRoadAddress = Console.ReadLine().ToUpper();
                    Console.WriteLine("pls Enter your order mail-box address");
                    orderMailBoxAddress = Console.ReadLine().ToUpper();


                    if(orderTypeEnter== "online")
                    {
                        orderType = OrderType.PhoneOrder;
                    }
                    else if (orderTypeEnter == "instore")
                    {
                        orderType = OrderType.RestaurantOrder;
                    }
                    else
                    {
                        Console.WriteLine("Error Type input");
                    }

                    orderCreate[orderCounter-1] = 
                        customerArray[customerCounter-1].CreateOrder(orderType,   
                        new Address(orderRoadAddress, orderMailBoxAddress));

                    Console.WriteLine("Do u want to choose sth to eat? y/n");
                    orderChooseAnother = Console.ReadLine().ToLower();

                    Console.WriteLine("*****************   Menu  ********************");
                    Console.WriteLine("||  Item          Cost         Description  ||");
                    chicken.GetInfor();
                    caviar.GetInfor();
                    avocado.GetInfor();
                    pop.GetInfor();
                    Console.WriteLine("*********  Order details as below  ***********");
                    Console.WriteLine();

                    for (; orderChooseAnother != "n";)
                    {
                        Console.WriteLine("Enter what do you want to order this " +
                                          "time: (Enter the item name in the menu)");
                        orderItemChoose = Console.ReadLine().ToLower();
                        switch (orderItemChoose)
                        {
                            case "chicken":
                                orderCreate[orderCounter - 1].AddOrderItem(oItem1);
                                break;
                            case "caviar":
                                orderCreate[orderCounter - 1].AddOrderItem(oItem2);
                                break;
                            case "avocado":
                                orderCreate[orderCounter - 1].AddOrderItem(oItem3);
                                break;
                            case "pop":
                                orderCreate[orderCounter - 1].AddOrderItem(oItem4);
                                break;
                            default:
                                Console.WriteLine("invalid choice");
                                break;
                        }

                        Console.WriteLine("Do u want to choose sth else? y/n");
                        orderChooseAnother = Console.ReadLine().ToLower();
                    }
                    Console.WriteLine("Do you want to create order? y/n");
                    orderMakeCheck = Console.ReadLine().ToLower();
                }

                for (int orderGetDeliveryCounter = 0; orderGetDeliveryCounter < orderCounter;orderGetDeliveryCounter++)
                {
                    Console.WriteLine("is order[{0}] delivered? y/n",orderCreate[orderGetDeliveryCounter].OrderId);
                    orderDeliveryCheck = Console.ReadLine().ToLower();
                    if (orderDeliveryCheck=="y")
                    {
                        orderCreate[orderGetDeliveryCounter].Delivered = true;
                    }
                    else
                    {
                        orderCreate[orderGetDeliveryCounter].Delivered = false;
                    }
                }

                Console.WriteLine("New customer? y/n, enter y will create the customer again");
                newcustomercheck = Console.ReadLine().ToLower();
                Console.WriteLine("Do you want to print out the created order " +
                                  "and customer information? y/n\n if y, will " +
                                  "print out the information without create new customer.");
                orderPrintCheck = Console.ReadLine().ToLower();
                if (newcustomercheck=="n"||orderPrintCheck=="y")
                {
                    newcustomercheck = "n";
                }
                else
                {

                }
            }

            for (int i = 0; i < customerCounter;i++)
            {
                customerArray[i].GetInfor();
            }
            for (int i = 0; i < orderCounter;i++)
            {
                orderCreate[i].GetInfor();
            }
            








           

            //Customer cus1 = new Customer("kate",  new Address("Brimely Road", "E5W9M3" ) , 4671234567);
            //Customer cus2 = new Customer("Bill", new Address("Eglington","E5W9M3"), 6471238900);
            //Customer cus3 = new Customer("Mary", new Address("London","B1Y5T6"), 6471238900);

            //Order order1 = cus1.CreateOrder(OrderType.PhoneOrder, new Address("road information for order 1","ABC"));
            //Order order2 = cus1.CreateOrder(OrderType.RestaurantOrder, new Address("road information for order 2", "MT35S9"));
            //Order order3 = cus2.CreateOrder(OrderType.PhoneOrder, new Address("road information for order 3", "CCC"));
            //Order order4 = cus3.CreateOrder(OrderType.RestaurantOrder, new Address("road information for order 4", "PPPPP"));


            //order1.AddOrderItem(oItem1);
            //order1.AddOrderItem(oItem2);
            //order1.AddOrderItem(oItem3);
            //order2.AddOrderItem(oItem1);
            //order3.AddOrderItem(oItem3);
            //order3.AddOrderItem(oItem4);
            //order4.AddOrderItem(oItem3);
            //order4.AddOrderItem(oItem2);
            //order4.AddOrderItem(oItem1);

            //order1.Delivered = true;
            //order2.Delivered = true;
            //order3.Delivered = false;
            //order4.Delivered = true;



            //cus1.GetInfor();
            //cus2.GetInfor();
            //cus3.GetInfor();

            //order1.GetInfor();
            //order2.GetInfor();
            //order3.GetInfor();
            //order4.GetInfor();

            Console.ReadKey();
        }

    }
}
