namespace MVC.Day6.Models.ViewModels;

public record StudentImage
{
    public int Id { get; set; }
    public IFormFile? Image { get; set; }
}
