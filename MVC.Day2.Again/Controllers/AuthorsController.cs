using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Day2.Again.Models;
using MVC.Day2.Again.Models.Domain;
using MVC.Day2.Again.Models.View;
using System.Linq;
using System.Text.Json;

namespace MVC.Day2.Again.Controllers;

public class AuthorsController : Controller
{
    private readonly ILogger<AuthorsController> _logger;
    private static List<Author> _authors = new();
    public AuthorsController(ILogger<AuthorsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(_authors);
    }

    #region Add

    [HttpGet]
    public IActionResult Add()
    {
        FillViewDataForForm();
        return View();
    }

    [HttpPost]
    public IActionResult Add(AddAuthorVM authorVM)
    {
        var author = new Author
        {
            Mail = authorVM.Mail,
            Password = authorVM.Password,
            IsActive = authorVM.IsActive,
            Language = authorVM.Language,
            Country = Country.GetCountries().First(c => c.Id == authorVM.CountryId),
            Awards = Award.GetAwards().Where(a => authorVM.Awards.Contains(a.Id)).ToList()
        };
        _logger.LogInformation(JsonSerializer.Serialize(author));
        _authors.Add(author);
        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Edit

    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        var authorToEdit = _authors.FirstOrDefault(a => a.Id == id);
        if (authorToEdit is null)
        {
            return View("Error");
        }

        var authorVM = new EditAuthorVM(id,
            authorToEdit.Mail,
            authorToEdit.Password,
            authorToEdit.IsActive,
            authorToEdit.Country.Id,
            authorToEdit.Language,
            authorToEdit.Awards.Select(a => a.Id).ToArray());

        FillViewDataForForm();
        return View(authorVM);
    }

    [HttpPost]
    public IActionResult Edit(EditAuthorVM authorVM)
    {
        var authorToEdit = _authors.First(a => a.Id == authorVM.Id);

        authorToEdit.Mail = authorVM.Mail;
        authorToEdit.Password = authorVM.Password;
        authorToEdit.IsActive = authorVM.IsActive;
        authorToEdit.Language = authorVM.Language;
        authorToEdit.Country = Country.GetCountries().First(c => c.Id == authorVM.CountryId);
        authorToEdit.Awards = Award.GetAwards()
            .Where(a => authorVM.Awards.Contains(a.Id))
            .ToList();

        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Helpers

    private void FillViewDataForForm()
    {
        ViewData[Strings.Countries] = Country.GetCountries().Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        ViewData[Strings.Awards] = Award.GetAwards().Select(c => new SelectListItem(c.Name, c.Id.ToString()));
    }

    #endregion
}
