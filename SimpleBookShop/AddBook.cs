using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookShop
{
    public class AddBook
    {
        public static void AddBookToList(List<Book> bookList)
        {
            Console.WriteLine("Add a book to the system");
            Console.Write("Title: ");
            string title = Console.ReadLine()!;

            Console.Write("Author:");
            string author = Console.ReadLine()!;

            Console.Write("ISBN:");
            if (int.TryParse(Console.ReadLine(), out int isbn))
            {
                Book newBook = new Book(title, author, isbn);
                bookList.Add(newBook);
                Console.WriteLine("Book added successfully.\n");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid ISBN, no book added.\n");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }


        }
    }
}
