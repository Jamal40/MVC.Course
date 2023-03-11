namespace Hospital.DAL.Models;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public int PerformanceRate { get; set; }

    public static string[] specializations = new[]
    {
        "Cardiology",
        "Pediatrics",
        "Neurology",
        "Oncology",
        "Dermatology",
        "Gastroenterology",
        "Endocrinology",
        "Hematology",
        "Infectious Disease",
        "Nephrology",
        "Pulmonology",
        "Rheumatology",
        "Urology"
    };

}
