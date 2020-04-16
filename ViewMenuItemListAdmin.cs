using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class ViewMenuItemListAdmin
    {
       
        public void ViewMenuItemAdmin()
        {
            var context = new truYumContext();
            var q = context.MenuItems.Include("Category").ToList();
            foreach (var menu in q)
            {
                Console.WriteLine(menu.Name);
                Console.WriteLine(menu.Price);

                Console.WriteLine(menu.DateOflaunch.ToShortDateString());
                Console.WriteLine(menu.Active);
                Console.WriteLine(menu.FreeDelivery);
                Console.WriteLine("********-------------------------------------*********************");
            }
        }
    }
}
