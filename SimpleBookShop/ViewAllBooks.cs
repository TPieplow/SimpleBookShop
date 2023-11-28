using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookShop
{
    internal class ViewAllBooks
    {
        public static void ViewAllBooksSearch(List<Book> bookList)
        {
            if (bookList != null)
            {
                foreach (Book book in bookList)
                {
                    Console.Clear();
                    Console.WriteLine("### The following books are available ###\n");
                    Console.WriteLine($"\tTitle: {book.Title}\n \tAuthor: {book.Author}\n \tISBN: {book.ISBN}");
                    Console.WriteLine("Press any key to continue");
                }
            }
            else
            {
                Console.WriteLine("No books available.");
                Console.WriteLine("Press any key to continue");
            }
            Console.ReadKey();
        }
    }
}
