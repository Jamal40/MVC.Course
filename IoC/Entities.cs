namespace IoC;
public record AuthorR(string Name = "", int NumberOfBooks = 0);

public class Author
{
    public string Name { get; set; } = string.Empty;
    public int NumberOfBooks { get; set; }
}