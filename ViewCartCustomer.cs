using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class ViewCartCustomer
    {
        public void ViewCartItems()
        {
            var context = new truYumContext();

            var query = context.Carts.Include("MenuItem").Where(iter => iter.UserId == 1).ToList();

            if (query.Count == 0)
            {
                Console.WriteLine("\nCart Empty");
            }
            else
            {
                Console.WriteLine("\nItems in Cart");
                foreach (var cart in query)
                {
                    Console.WriteLine(cart.menuItem.Name);
                    Console.WriteLine(cart.menuItem.Price);

                    Console.WriteLine("------------------------");

                }
            }
        }
    }
}
