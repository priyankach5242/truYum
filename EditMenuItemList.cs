using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYum
{
    public class EditMenuItemList
    {

        public void EditMenuItem(string menuItemName)
        {
            var context = new truYumContext();
            var query = from menu in context.MenuItems where menu.Name == menuItemName select menu;
            if (query == null)
            {
                Console.WriteLine("Incorrect menu item.please check\n");

            }
            else
            {

                bool datacorrectness = true;
                while (datacorrectness)
                {
                    if (query == null || query.First().Name == " ")
                    {

                        Console.WriteLine("Incorrect name.Please provide valid name");
                        menuItemName = Console.ReadLine();
                        datacorrectness = false;
                        break;
                    }
                    else
                    {
                        var cat = from category in context.Categories where category.Name == query.First().category.Name select category;
                        if (cat == null)
                        {
                            Console.WriteLine("Incorrect category.Please reenter data");
                            datacorrectness = false;

                        }
                        else
                        {
                            Console.WriteLine("All data is correct");
                            Console.WriteLine("Enter price to edit");
                            query.First().Price = double.Parse(Console.ReadLine());
                            datacorrectness = false;
                            context.MenuItems.AddOrUpdate();
                            context.SaveChanges();
                            Console.WriteLine("Data is saved,Here is the updated data");
                            ViewMenuItemListAdmin viewdata = new ViewMenuItemListAdmin();
                            viewdata.ViewMenuItemAdmin();
                        }
                    }
                }


            }
        }
    }
    
}
