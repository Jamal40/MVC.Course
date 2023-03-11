using Microsoft.AspNetCore.Mvc;
using MVC.Day._1.Models;

namespace MVC.Day._1.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult BooksList()
        {
            var books = Book.GetBooksList();
            return View(books);
        }

        public IActionResult TryingParams(Guid? id, string? author)
        {
            var book = Book.GetBooksList().FirstOrDefault(b => b.Id == id || b.Author == author);
            return View(book);
        }

        public static string GetMeTheType<T>()
        {
            return typeof(T).Name;
        }
    }
}
