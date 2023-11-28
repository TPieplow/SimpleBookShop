namespace SimpleBookShop;

public class Program
{
    static List<Book> bookList = [];

    static void Main()
    {
        while (true)
        {

            Console.WriteLine("Välkommen till min bokhanterare");
            string[] menuOptions = ["1. Add a book", "2. Find a book", "3. Show all books", "0. Exit application"];

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewSingleBook();
                    break;
            }   
        }
    }
}