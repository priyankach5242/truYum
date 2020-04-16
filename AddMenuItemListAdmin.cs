using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class AddMenuItemListAdmin
    {
        public void AddMenuItem(string name, string category, double price, Boolean isActive, DateTime dateOfLaunch, Boolean freeDelivery)
        {
            var context = new truYumContext();
            int categoryId = context.Categories.Where(iter => iter.Name.Equals(category, StringComparison.OrdinalIgnoreCase)).Select(iter => iter.Id).FirstOrDefault();
            MenuItem menuItem = new MenuItem();
            menuItem.Name = name;
            menuItem.Price = price;
            menuItem.Active = isActive;
            menuItem.DateOflaunch = dateOfLaunch;
            menuItem.FreeDelivery = freeDelivery;
            if (!Convert.ToBoolean(categoryId))
            {
                Console.WriteLine("\nCategory does not exist");

            }
            else
            {
                menuItem.CategoryId = categoryId;

                context.MenuItems.Add(menuItem);
                Console.WriteLine("\nAdded Successfully");
                context.SaveChanges();
            }
        }
    }
}

