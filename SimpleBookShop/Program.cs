﻿namespace SimpleBookShop;

public class Program
{
    public void BookShopMenu()
    {
        List<Book> bookList = [];
        while (true)
        {

            Menu.MenuOptions();

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AddBook.AddBookToList(bookList);
                    break;

                case "2":
                    ViewSingleBook.ViewSingleBookSearch(bookList);
                    break;

                case "3":
                    ViewAllBooks.ViewAllBooksSearch(bookList);
                    break;

                case "0":
                    ExitApplication.ExitApplicationOption();
                    break;

                default:
                    Console.WriteLine("Not a valid option");
                    break;

            }
            Console.Clear();
        }
    }
}