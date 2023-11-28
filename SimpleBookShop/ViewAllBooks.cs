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
                    Console.WriteLine($"Title: {book.Title}\n Author: {book.Author}\n ISBN: {book.ISBN}");
                }
            }
            else
            {
                Console.WriteLine("No books available.");
            }
            Console.ReadKey();
        }
    }
}
