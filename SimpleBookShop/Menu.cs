using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookShop
{
    internal class Menu
    {
        public static void MenuOptions()
        {
            string[] menuOptions = {
                "1. Add a book",
                "2. Find a book",
                "3. Show all books",
                "0. Exit application"
            };

            Console.WriteLine("Välkommen till min bokhanterare");
            Console.WriteLine("*******************************");

            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine(menuOptions[i]);
            }

            Console.WriteLine("*******************************");
        }
    }
}
