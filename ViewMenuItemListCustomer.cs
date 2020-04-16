using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class ViewMenuItemListCustomer
    {
        public void ViewMenuItemsCustomer()
        {
            var context = new truYumContext();

            var query = context.MenuItems.Where(iter => iter.Active == true && System.Data.Entity.DbFunctions.DiffDays(DateTime.Now, iter.DateOflaunch) < 0).ToList();

            foreach (var menu in query)
            {

                Console.WriteLine("Id " + menu.Id);
                Console.WriteLine("Name " + menu.Name);
                Console.WriteLine("Price " + menu.Price);

                Console.WriteLine("FreeDelivery " + menu.FreeDelivery);
                Console.WriteLine("DateOflaunch " + menu.DateOflaunch);
                Console.WriteLine("Active " + menu.Active);
                Console.WriteLine("****--------------------------------*****");

            }
        }
    }
}
