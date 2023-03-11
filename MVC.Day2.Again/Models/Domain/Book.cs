namespace MVC.Day2.Again.Models.Domain;

public class Book
{
    #region Props

    public Guid Id { get; set; }
    public string? Title { get; set; }
    public double Price { get; set; }

    #endregion

    #region constructors 

    public Book() { }
    public Book(Guid id,
        string title,
        double price)
    {
        Id = id;
        Title = title;
        Price = price;
    }

    #endregion

    #region Initial List

    private static readonly List<Book> _books = new()
    {
        new Book(Guid.NewGuid(), "The Great Gatsby", 12.99),
        new Book(Guid.NewGuid(), "To Kill a Mockingbird",  10.99),
        new Book(Guid.NewGuid(), "1984", 9.99),
        new Book(Guid.NewGuid(), "Pride and Prejudice", 7.99),
        new Book(Guid.NewGuid(), "The Catcher in the Rye", 11.99),
        new Book(Guid.NewGuid(), "Brave New World", 8.99),
        new Book(Guid.NewGuid(), "The Hobbit", 13.99),
        new Book(Guid.NewGuid(), "The Lord of the Rings", 29.99),
        new Book(Guid.NewGuid(), "The Hitchhiker's Guide to the Galaxy", 6.99),
        new Book(Guid.NewGuid(), "Harry Potter and the Philosopher's Stone", 14.99)
    };

    #endregion

    public static List<Book> GetBooksList() => _books;
}
