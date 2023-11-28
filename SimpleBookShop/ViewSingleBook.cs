using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookShop
{
    internal class ViewSingleBook
    {

        public static void ViewSingleBookSearch(List<Book> bookList) 
        {
            Console.Write("Enter ISBN to search for a book: ");

            if(int.TryParse(Console.ReadLine(), out int isbn))
            {
                Book? foundBook = bookList.Find(book => book.ISBN == isbn);

                if (foundBook != null)
                {
                    Console.WriteLine($"Title: {foundBook.Title}");
                    Console.WriteLine($"Author: {foundBook.Author}");
                    Console.WriteLine($"ISBN: {foundBook.ISBN}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Couldnt find a book with the coresponding ISBN: {isbn}");
                }
            }
            else
            { 
                Console.WriteLine("Invalid ISBN");
            }
        }
    }
}
