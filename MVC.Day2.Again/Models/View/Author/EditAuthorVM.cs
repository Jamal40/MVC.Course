namespace MVC.Day2.Again.Models.View;
public record EditAuthorVM(Guid Id, 
    string Mail,
    string Password,
    bool IsActive,
    int CountryId,
    Languages Language,
    int[] Awards);

