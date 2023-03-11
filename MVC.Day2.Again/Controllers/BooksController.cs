using Microsoft.AspNetCore.Mvc;
using MVC.Day2.Again.Models.Domain;
using MVC.Day2.Again.Models.View;

namespace MVC.Day2.Again.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View(Book.GetBooksList());
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(AddBookVM bookVM)
    {
        //Mapping view model to a domain model
        Book bookToAdd = new(Guid.NewGuid(), bookVM.Title, bookVM.Price);

        //Perform yourt business logic with your domain model
        Book.GetBooksList().Add(bookToAdd);

        //Hanlde View
        return RedirectToAction(nameof(Index));
    }
}
