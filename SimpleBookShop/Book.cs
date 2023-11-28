
namespace SimpleBookShop;

public class Book
{

    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int ISBN { get; set; }

    public Book(string title, string author, int isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}
