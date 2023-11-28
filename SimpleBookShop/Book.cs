
namespace SimpleBookShop;

public class Book(string title, string author, int isbn)
{

    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public int ISBN { get; set; } = isbn;
}
