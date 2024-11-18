using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara_Star_Hotel_Mgmt_System
{
    internal class Restaurant
    {
        private List<Menu> item = new List<Menu>();
        private List<OrderItem> orderItems = new List<OrderItem>();

        public void ListOfItems()
        {
            item.Add(new Menu(1, "MASALA PAPAD", 55));
            item.Add(new Menu(2, "FRY PAPAD", 30));
            item.Add(new Menu(3, "MANCHOW SOUP", 140));
            item.Add(new Menu(4, "BOONDI RAITA", 100));
            item.Add(new Menu(5, "PANEER CHILLY", 310));
            item.Add(new Menu(6, "PANEER CRISPY", 290));
            item.Add(new Menu(7, "PANEER PERI PERI", 250));
            item.Add(new Menu(8, "PANEER TIKKA", 265));
            item.Add(new Menu(9, "VEG KOLHAPURI", 210));
            item.Add(new Menu(10, "VEG MARATHA", 230));
            item.Add(new Menu(11, "BUTTER ROTI", 50));
            item.Add(new Menu(12, "BUTTER NAAN", 70));
            item.Add(new Menu(13, "DAL FRY", 220));
            item.Add(new Menu(14, "JEERA RICE", 180));
            item.Add(new Menu(15, "BIRYANI", 150));
        }

        public void DisplayMenu()
        {
            try
            {
                if (item.Count == 0)
                {
                    ListOfItems();
                }
                Console.WriteLine("\nGST 5% Extra");
                foreach (var menu in item)
                {
                    Console.WriteLine(menu);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Error To Display The Menu Items");
            }
        }

        public void PlaceOrder()
        {
            try
            {
                Console.WriteLine("\nHow Many Item You Want To Add in List");
                int length = Convert.ToInt32(Console.ReadLine());

                for(int i =0; i < length; i++)
                {
                    Console.WriteLine("Enter The Item Id You Want To Order");
                    int itemId = Convert.ToInt32(Console.ReadLine());

                    Menu SelectedItem = item.Find(m => m.Id == itemId);

                    if (SelectedItem == null)
                    {
                        Console.WriteLine("Invalid Item Number");
                        return;
                    }
                    Console.WriteLine($"Enter Quantity For {SelectedItem.Name}");
                    int Quantity = Convert.ToInt32(Console.ReadLine());

                    orderItems.Add(new OrderItem(SelectedItem, Quantity));
                    Console.WriteLine($"{SelectedItem.Name} has Been Added To Your Order Sucessfully.");
                    Console.WriteLine();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}Error For Placing The Order");
            }
        }

        public void ViewOrder()
        {
            if (orderItems.Count == 0)
            {
                Console.WriteLine("You Have Not Placed Any Order Yet");
                return;
            }
            Console.WriteLine("\nYour Order Is:-");
            Console.WriteLine("GST 5% Extra");
            foreach (var item in orderItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void Bill()
        {
            try
            {
                int TotalAmt = 0;
                Console.WriteLine();
                foreach (var item in orderItems)
                {
                    Console.WriteLine(item);
                    TotalAmt += item.GstTotalPrice();
                } 
                int gst = TotalAmt * 5 / 100;
                int Total = TotalAmt + gst;
                Console.WriteLine($"Gross Total :- {TotalAmt}");
                Console.WriteLine($"5% GST On Total :- {gst}");
                Console.WriteLine($"Net Payable Amount :- {Total}");
                Console.WriteLine("Thanks For Visit, Please Proceed to Payment...\n");

                //Clear The Menu and Order List After Checkout
                item.Clear();
                orderItems.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Error To Fetch The Bill");
            }
        }
    }
}
