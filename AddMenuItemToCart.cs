using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
        public class AddMenuItemToCart
        {
            public void AddToCart(string menuItemName)
            {
                var context = new truYumContext();
                var query = from menu in context.MenuItems where menu.Name == menuItemName select menu;
                bool datacorrectness = true;
                while (datacorrectness)
                {
                    if (query == null)
                    {
                        Console.WriteLine("Incorrect menu item name.Please reenter");
                        datacorrectness = false;
                    }
                    else
                    {
                        int userId = 1;
                        Cart c = new Cart();
                        c.UserId = userId;
                        c.MenuItemId = query.First().Id;
                        context.Carts.Add(c);
                        context.SaveChanges();

                        Console.WriteLine("Menu item added to cart successfully");
                        Console.WriteLine("Do you want to continue adding to cart[Y|N]");
                        char ch = char.Parse(Console.ReadLine());
                        if (ch == 'N')
                        {
                            datacorrectness = false;
                            break;
                        }
                        Console.WriteLine("Enter the name of the item to add into cart");
                        AddToCart(Console.ReadLine());
                    }
                }
            }
        }
    
}
