using System.ComponentModel.DataAnnotations;
using Your_Project_Name.Models.Domain;

namespace MVC.Day3.Data.Models;

public class TicketDb
{
    public int Id { get; set; }
    
    [Required]
    public string Title { get; set; }= string.Empty;
    
    [Required]
    public string Description { get; set; }= string.Empty;

    public Severity Severity { get; set; }
}
