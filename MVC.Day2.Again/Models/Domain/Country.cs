namespace MVC.Day2.Again.Models.Domain;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Country(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public static List<Country> GetCountries() => new()
    {
        new (1, "Egypt"),
        new (2, "KSA"),
        new (3, "Mexico"),
        new (4, "Brazil"),
        new (5, "France"),
        new (6, "Germany"),
        new (7, "Spain"),
        new (8, "China"),
        new (9, "Japan"),
        new (10, "Australia"),
        new (11, "United States"),
        new (12, "Canada"),
    };

    public override string ToString() => Name;
}
