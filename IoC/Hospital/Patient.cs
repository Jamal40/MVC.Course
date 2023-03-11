using System.ComponentModel.DataAnnotations;

namespace Hospital.DAL.Models;

public class Patient
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int DoctorId { get; set; }
}
