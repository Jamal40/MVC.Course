using System.Text.Json;

namespace LINQ_Examples;

public record Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }= string.Empty;
    public string Category { get; set; }= string.Empty;
    public double Price { get; set; }
    public int Stock { get; set; }

    public static List<Product> GetProducts => JsonSerializer.Deserialize<List<Product>>("""[{"Id":"89dbabcd-ca2a-44b5-8c3b-ba50655baaed","Name":"Tuna","Category":"ratione","Price":807.5477578656778,"Stock":20},{"Id":"fb3fb8db-e281-4f6a-9f9b-6c5f76992255","Name":"Pizza","Category":"repellendus","Price":157.1683227303238,"Stock":17},{"Id":"bce60455-583a-4b2e-bf8e-f0aad92b0c7c","Name":"Computer","Category":"enim","Price":788.015294887841,"Stock":10},{"Id":"583f64f6-5add-40b8-88eb-4385997eb7c8","Name":"Bacon","Category":"modi","Price":228.93037234972556,"Stock":19},{"Id":"04ede26e-5aa3-4ea2-9f4c-e8915d0f97cf","Name":"Cheese","Category":"nostrum","Price":657.1709030205816,"Stock":20},{"Id":"529d263d-00cc-43a7-9ba1-d0147ad1e2d2","Name":"Towels","Category":"eaque","Price":667.9253096468491,"Stock":17},{"Id":"34ad7587-823d-4160-8a62-c58336300abd","Name":"Gloves","Category":"repellat","Price":944.7548650368174,"Stock":18},{"Id":"42a0b465-789a-48b3-9d01-a289cd817b85","Name":"Towels","Category":"hic","Price":567.9431242333538,"Stock":18},{"Id":"e5680c84-e74f-4b6d-909c-d5c0dfe9b512","Name":"Bacon","Category":"voluptate","Price":155.20985573826496,"Stock":17},{"Id":"b8175b78-1ea6-40e3-89a8-ad075345c549","Name":"Gloves","Category":"cumque","Price":199.81347277974456,"Stock":11}]""") ?? new();
}
