using Bogus;
using Hospital.DAL.Models;
using LINQ_Examples;
using MVC.Day3.Data.Models;
using System.Text.Json;
using Your_Project_Name.Models.Domain;

var name = "Asmaa";
var age = 23;

var resultString = $"{name} is {age} years old";
var _resultString = string.Format("{0} is {1} years old, {2}", name, age, DateTime.Now);
Console.WriteLine(_resultString);

#region Faking Data

//var developers = new Faker<Developer>()
//    .RuleFor(d => d.Id, f => Guid.NewGuid())
//    .RuleFor(d => d.FirstName, f => f.Person.FirstName)
//    .RuleFor(d => d.LastName, f => f.Person.LastName)
//    .Generate(5);

//var developers = new Faker<MyDev>()
//    .RuleFor(d => d.Id, f => f.IndexFaker + 1)
//    .RuleFor(d => d.Name, f => f.Person.FirstName)
//    .Generate(20);

//var departments = new Faker<Department>()
//    .RuleFor(d => d.Id, f => Guid.NewGuid())
//    .RuleFor(d => d.Name, f => f.Commerce.Department())
//    .Generate(3);

//var tickets = new Faker<Ticket>()
//    .RuleFor(a => a.Id, f => Guid.NewGuid())
//    .RuleFor(a => a.Description, f => f.Lorem.Sentence())
//    .RuleFor(a => a.IsClosed, f => f.Random.Bool())
//    .RuleFor(a => a.Severity, f => f.Random.Enum<Severity>())
//    .RuleFor(a => a.Developers, f => f.Random.ArrayElements(Developer.GetDevelopers().ToArray()))
//    .RuleFor(a => a.Department, f => f.Random.ArrayElement(Department.GetDepartments().ToArray()))
//    .Generate(4);

//var ticketsDb = new Faker<TicketDb>()
//    .RuleFor(a => a.Id, f => f.IndexFaker + 1)
//    .RuleFor(a => a.Description, f => f.Commerce.Random.Word())
//    .RuleFor(a => a.Title, f => f.Commerce.Department())
//    .RuleFor(a => a.Severity, f => f.Random.Enum<Severity>())
//    .Generate(20);

//var products = new Faker<Product>()
//    .RuleFor(a => a.Id, f => Guid.NewGuid())
//    .RuleFor(a => a.Name, f => f.Commerce.Product())
//    .RuleFor(a => a.Stock, f => f.Random.Int(10, 20))
//    .RuleFor(a => a.Price, f => f.Random.Double(5, 1000))
//    .RuleFor(a => a.Category, f => f.Lorem.Word())
//    .Generate(10);

//var names = new Faker<string>()
//    .RuleFor(a => a, f => f.Name.FirstName())
//    .Generate(20);
//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\mydevelopers.json",
//    JsonSerializer.Serialize(developers));

//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\tickets.json",
//    JsonSerializer.Serialize(tickets));

//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\products.json",
//    JsonSerializer.Serialize(products));

//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\departments.json",
//    JsonSerializer.Serialize(departments));

//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\ticketsDb.json",
//    JsonSerializer.Serialize(ticketsDb));

//File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\ticketsDb.json",
//    JsonSerializer.Serialize(names));

#endregion

#region Hospital

var doctors = new Faker<Doctor>()
    .RuleFor(d => d.Id, f => f.IndexFaker + 1)
    .RuleFor(d => d.Name, f => f.Person.FirstName)
    .RuleFor(d => d.Specialization, f => f.Random.ArrayElement(Doctor.specializations))
    .RuleFor(d => d.Salary, f => f.Random.Int(5000, 50000))
    .RuleFor(d => d.PerformanceRate, f => f.Random.Int(0, 100))
    .Generate(10);


var patients = new Faker<Patient>()
    .RuleFor(p => p.Id, f => f.IndexFaker + 1)
    .RuleFor(p => p.Name, f => f.Person.FirstName)
    .RuleFor(p => p.DoctorId, f => f.Random.Int(1, 10))
    .Generate(30);


var issues = Issue.IssuesNames().Select((n, i) => new Issue { Name = n, Id = i + 1 }).ToList();

File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\doctors.json",
    JsonSerializer.Serialize(doctors));

File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\patients.json",
    JsonSerializer.Serialize(patients));

File.WriteAllText("C:\\Users\\Jamal\\OneDrive\\Documents\\GitHub\\MVC.Day.1\\IoC\\issues.json",
    JsonSerializer.Serialize(issues));

#endregion

#region Hide

//var authorsR = JsonSerializer.Deserialize<List<AuthorR>>("""[{"Name":"Ottis","NumberOfBooks":20},{"Name":"Henri","NumberOfBooks":57},{"Name":"Carol","NumberOfBooks":56},{"Name":"Chesley","NumberOfBooks":11},{"Name":"Guillermo","NumberOfBooks":55},{"Name":"Kaelyn","NumberOfBooks":59},{"Name":"Marie","NumberOfBooks":67},{"Name":"Otha","NumberOfBooks":57},{"Name":"Zane","NumberOfBooks":67},{"Name":"Jerad","NumberOfBooks":62},{"Name":"Patrick","NumberOfBooks":25},{"Name":"Hazel","NumberOfBooks":96},{"Name":"Kadin","NumberOfBooks":66},{"Name":"Nya","NumberOfBooks":21},{"Name":"Grayce","NumberOfBooks":59},{"Name":"Sincere","NumberOfBooks":52},{"Name":"Palma","NumberOfBooks":82},{"Name":"Kennedi","NumberOfBooks":48},{"Name":"Kimberly","NumberOfBooks":85},{"Name":"Jon","NumberOfBooks":51}]""");

//foreach (var item in Ticket.GetTickets())
//{
//    Console.WriteLine($"{item.Description}, {item.Developers.Count}, {item.Department?.Name}");
//    Console.WriteLine($"{Developer.GetDevelopers().First(d => d.Id == item.Developers.First().Id).FirstName}");
//}

#endregion

#region random
Projections.HeavySelect();
#endregion

var t = 0;



