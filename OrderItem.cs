using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara_Star_Hotel_Mgmt_System
{
    internal class OrderItem
    {
        //Properties
        public Menu Menu { get; set; }
        public int Quantity { get; set; }
        
        //Constructor To OrderItem
        public OrderItem(Menu menu, int quantity)
        {
            Menu = menu;
            Quantity = quantity;
        }

        //Calculate Total Food Amount 
        public int GstTotalPrice()
        {
            return Menu.Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Menu.Name} (Quantity x{Quantity})  $(Total:-({Menu.Price} * {Quantity}) = {GstTotalPrice()})";
        } 

    }
}
