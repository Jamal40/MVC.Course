namespace Hospital.DAL.Models;

public class Issue
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public static List<string> IssuesNames() => new()
    {
        "Diabetes",
        "Hypertension",
        "Asthma",
        "Depression",
        "Arthritis",
        "Allergy",
        "Flu"
    };
}
