using Bogus.DataSets;
using Microsoft.AspNetCore.Mvc;
using MVC.Day2.Models;
using MVC.Day2.Models.ViewModels;

namespace MVC.Day2.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var props = typeof(Book).GetProperties().Select(p => p.Name);
        return View(Book.GetBooksList());
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(AddBookVM book)
    {
        if (IsModelInvalid())
        {
            return View(book);
        }

        var ids = book.ReviewersString
            .Split(",") //Array of strings
            .Select(idStr => int.Parse(idStr))
            .ToList();

        //Book.AddToList(new Book(Guid.NewGuid(), "", "", 1990, "", 0));
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult AddAuthor()
    {
        return View();
    }

    [HttpPost]
    [Route("{authorId:int}")]
    public IActionResult AddAuthor(Author author)
    {
        return View();
    }


    [HttpGet]
    public IActionResult EditAuthor(string name)
    {
        Author authorToEdit = Author.GetAuthors().First(a => a.Name == name);
        return View(authorToEdit);
    }

    [HttpPost]
    public IActionResult EditAuthor(Author author)
    {
        _logger.LogInformation(author.ToString());
        return View();
    }

    private bool IsModelInvalid() => !ModelState.IsValid;
}
