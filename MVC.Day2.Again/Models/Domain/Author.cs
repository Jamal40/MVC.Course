using MVC.Day2.Again.Models.View;

namespace MVC.Day2.Again.Models.Domain;
public class Author
{
    public Guid Id { get; set; }
    public string Mail { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public Country Country { get; set; }
    public Languages Language { get; set; }
    public List<Award> Awards { get; set; }

    public Author()
    {
        Id = Guid.NewGuid();
    }

    public Author(string mail,
        string password,
        bool isActive,
        Country country,
        Languages language,
        List<Award> awards)
    {
        Id = Guid.NewGuid();
        Mail = mail;
        Password = password;
        IsActive = isActive;
        Country = country;
        Language = language;
        Awards = awards;
    }
}