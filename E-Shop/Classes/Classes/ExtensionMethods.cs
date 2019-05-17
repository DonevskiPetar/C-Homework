using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.VendorsAndProducts;

namespace Classes.Classes
{
    public static class ExtensionMethods
    {
        
        public static User RegisterUser()
        {
            Console.WriteLine("-----------------------------------Welcome to the E-Shop!-----------------------------------");
            Console.WriteLine("---------------Please register , enter your desired username(4 char or more):---------------");

            string username = Console.ReadLine();

            if(!String.IsNullOrEmpty(username) && username.Length > 3)
            {
                User user = new User(username);
                Console.WriteLine($"----------------------------  You are registered , Welcome {username} --------------------------");
                return user;
            }
            else
            {
                Console.WriteLine("--------------------Registration was NOT succesfull , please try again!-------------------");
                System.Threading.Thread.Sleep(2000);
                return RegisterUser();
            }
        }
        
        public static void UserActions()
        {
            Console.WriteLine("-------------------------Please choose one of the following actions:------------------------");
            Console.WriteLine("1.Get the full list of vendors");
            Console.WriteLine("2.Search all products based on Vendors name with name and price");
            Console.WriteLine("3.Create a new order by providing product code and quantity and add to user orders");
            Console.WriteLine("4.Get state of shopping cart (name / quantity / price)");
            Console.WriteLine("5.Remove existing order by index");
            Console.WriteLine("6.Finish order with order receipt including username , products name quantity and price and total price");
            Console.WriteLine("7.Exit shop");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            string userAction = Console.ReadLine();

            switch (userAction)
            {
                case "1":
                    Console.WriteLine("------------------------------------List of all Vendors:------------------------------------");

                    VendorsAndProducts.VendorsAndProducts.GetAllVendors();

                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    UserActions();
                    break;

                case "2":
                    Console.WriteLine("-------------------------------------List of all products-----------------------------------");

                    VendorsAndProducts.VendorsAndProducts.GetAllVendorsAndProducts();

                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    UserActions();
                    break;

                case "3":
                    Console.WriteLine("--------------------------Please follow the steps to make an order--------------------------");

                    Console.WriteLine("--------------------------------Enter the ID of the Product:--------------------------------");
                    int inputProductId = int.Parse(Console.ReadLine());

                    foreach (var item in VendorsAndProducts.VendorsAndProducts.VendorsProducts)
                    {

                        foreach (var item2 in item.Value)
                            {
                            if (inputProductId == item2.ID)
                                {
                                    Console.WriteLine("-------------------------You choosed" + item2.ID + " " + item2.ProductName + " " + item2.ProductPrice + "-------------------------");                                  Console.WriteLine("-------------------------------------Enter the amount:--------------------------------------");

                                    int inputAmount = int.Parse(Console.ReadLine());
                                    Order.orders.Add(new Order(item2.ID ,item2.ProductName, inputAmount, item2.ProductPrice));
                                    
                                    Console.WriteLine($"----------------------------You have succesfully made an order-----------------------------");
                                    UserActions();
                                }
                                    
                            }

                    }

                    break;
                case "4":
                    foreach (var item in Order.orders)
                    {
                        Console.WriteLine($"--------------------State of shopping cart: Order ID: {item.ID} Product: {item.ProductName} Quantity: {item.ProductQuantity} Price {item.ProductPrice}--------------------");
                    }
                    UserActions();

                    break;
                case "5":
                    Console.WriteLine("-----------------------Enter the order ID number to remove an order:------------------------");
                    int orderRemoveID = int.Parse(Console.ReadLine());

                    try
                    {
                        foreach (var item in Order.orders)
                        {
                            if (orderRemoveID == item.ID)
                            {
                                Order.orders.Remove(item);
                                Console.WriteLine("-----------------------The order was removed from your shopping cart------------------------");
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    UserActions();
                    break;
                case "6":
                    Console.WriteLine("------Order receipt including username , products name quantity and price and total price----");
                    foreach (var item in User._users)
                    {
                        Console.WriteLine($"Order receipt for {item.UserName}");
                    }
                    foreach (var item in Order.orders)
                    {
                        Console.WriteLine($"{item.ProductName} {item.ProductPrice} {item.ProductQuantity} TOTAL: {item.ProductPrice * item.ProductQuantity}");
                    }
                    UserActions();
                    break;
                case "7":
                    Console.WriteLine("------------------------Thank You for your visit , have a nice day!-------------------------");
                    break;
                default:
                    Console.WriteLine("-------------------Invallid input , please enter number from 1 to 7-------------------");
                    UserActions();
                    break;
            }
            
            
        }
    }
}
