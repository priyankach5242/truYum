using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the user type\n 1.Admin \n 2.Customer");
            int userType = int.Parse(Console.ReadLine());
            switch(userType)
            {
                case 1:
                    Console.WriteLine("\n 1.View Menu Items\n 2.Add Menu Items\n 3.Edit Menu items\n");
                    int adminOperation = int.Parse(Console.ReadLine());
                    switch(adminOperation)
                    {
                        case 1:
                            var viewAdmin = new ViewMenuItemListAdmin();
                            viewAdmin.ViewMenuItemAdmin();
                            break;
                        case 2:
                            var addAdmin = new AddMenuItemListAdmin();
                            Console.WriteLine("Enter name,category,price,active(true|false),dateoflaunch,freedelivery(true|false)");
                            string name = Console.ReadLine();
                            string category = Console.ReadLine();
                            double price = double.Parse(Console.ReadLine());
                            bool active = bool.Parse(Console.ReadLine());
                            DateTime dateofLaunch = DateTime.Parse(Console.ReadLine());
                            bool freedelivery = bool.Parse(Console.ReadLine());
                            addAdmin.AddMenuItem(name, category, price, active, dateofLaunch, freedelivery);
                            break;
                        case 3:
                            var editAdmin = new EditMenuItemList();
                            Console.WriteLine("Enter the menuItem name to edit");
                            editAdmin.EditMenuItem("Console.ReadLine()");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("\n1.View Menu For Customer\n2.View cart Items \n 3. add menuItem to Cart \n 4.Remove Item from cart \n");
                    int userOperation = int.Parse(Console.ReadLine());
                    switch (userOperation)
                    {
                        case 1:
                            var viewMenuItemCustomer = new ViewMenuItemListCustomer();
                            viewMenuItemCustomer.ViewMenuItemsCustomer();
                            break;
                        case 2:
                            var viewCart = new ViewCartCustomer();
                            viewCart.ViewCartItems();
                            break;
                        case 3:
                            var addCart = new AddMenuItemToCart();
                            Console.WriteLine("Enter the name of the item to add into cart");
                            addCart.AddToCart(Console.ReadLine());
                            break;
                        case 4:
                            var removeItem = new RemoveCartItem();
                            Console.WriteLine("\nEnter the name of item to remove from cart");
                            removeItem.RemoveFromCart(Console.ReadLine());
                            break;
                    }
                    break;
            }
        }
    }
}
