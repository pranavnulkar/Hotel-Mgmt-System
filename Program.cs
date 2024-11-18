using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sahara_Star_Hotel_Mgmt_System
{
    internal class Hotel
    {
        static void Main()
        {
            Restaurant restaurant = new Restaurant();
            int Choice;
            do
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("WELCOME TO SAHARA STAR HOTEL");
                Console.WriteLine("1.Display Menu");
                Console.WriteLine("2.Place Order");
                Console.WriteLine("3.View Order");
                Console.WriteLine("4.Your Bill");
                Console.WriteLine("5.Exit Menu");
                Console.WriteLine("*****************************************");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        restaurant.DisplayMenu();
                        break;
                    case 2:
                        restaurant.PlaceOrder();
                        break;
                    case 3:
                        restaurant.ViewOrder();
                        break;
                    case 4:
                        restaurant.Bill();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice...");
                        break;
                }
            } while (Choice < 5);

        }
    }
}
