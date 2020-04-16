using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class RemoveCartItem
    {
        public void RemoveFromCart(string menuItemName)
        {
            var context = new truYumContext();
            var query = context.Carts.Include("MenuItem").Where(iter => iter.UserId == 1).ToList();
            if (query == null)
            {
                Console.WriteLine("No item in cart for the user");

            }
            else
            {
                bool datacorrectness = true;
                int f = 0;
                while (datacorrectness)
                {
                    foreach (var cart in query)
                    {

                        if (cart.menuItem.Name == menuItemName)
                        {
                            context.Carts.Remove(cart);
                            Console.WriteLine("Menu Item removed from cart successfully");
                            datacorrectness = false;
                            f = 1;
                        }
                    }
                    if (f == 0)
                    {
                        Console.WriteLine("Incorrect menu item name Please reenter");
                    }
                }
            }
            context.SaveChanges();
        }
    }
}
