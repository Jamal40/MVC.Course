using System.Text.Json;

namespace MVC.Day2.Models;

public record Author(string Name, int NumberOfBooks)
{
    private static readonly List<Author> _authors = JsonSerializer.Deserialize<List<Author>>("""[{"Name":"Ottis","NumberOfBooks":20},{"Name":"Henri","NumberOfBooks":57},{"Name":"Carol","NumberOfBooks":56},{"Name":"Chesley","NumberOfBooks":11},{"Name":"Guillermo","NumberOfBooks":55},{"Name":"Kaelyn","NumberOfBooks":59},{"Name":"Marie","NumberOfBooks":67},{"Name":"Otha","NumberOfBooks":57},{"Name":"Zane","NumberOfBooks":67},{"Name":"Jerad","NumberOfBooks":62},{"Name":"Patrick","NumberOfBooks":25},{"Name":"Hazel","NumberOfBooks":96},{"Name":"Kadin","NumberOfBooks":66},{"Name":"Nya","NumberOfBooks":21},{"Name":"Grayce","NumberOfBooks":59},{"Name":"Sincere","NumberOfBooks":52},{"Name":"Palma","NumberOfBooks":82},{"Name":"Kennedi","NumberOfBooks":48},{"Name":"Kimberly","NumberOfBooks":85},{"Name":"Jon","NumberOfBooks":51}]""") ?? new();
    public static List<Author> GetAuthors() => _authors;
}

//public class Author2
//{
//    public Author2(string name, int numberOfBooks)
//    {
//        Name = name;
//        NumberOfBooks = numberOfBooks;
//    }

//    public string Name { get; init; }
//    public int NumberOfBooks { get; init; }
//}