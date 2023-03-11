using Microsoft.AspNetCore.Mvc;
using MVC.Day3.Models;
using System.Diagnostics;

namespace MVC.Day3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/StatusCode/{statusCode}")]
        public IActionResult Error(string statusCode)
        {
            return View(new ErrorViewModel { RequestId = statusCode });
        }
    }
}