namespace SimpleBookShop;

public class Book
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int? ISBN { get; set; }

    public Book()
    {
        Title = "Ted";
        Author = "Pieplow";
        ISBN = 123;
    }
}
