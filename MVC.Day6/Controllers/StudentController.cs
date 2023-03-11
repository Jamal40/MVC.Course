using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MVC.Day6.Models.Options;
using MVC.Day6.Models.ViewModels;

namespace MVC.Day6.Controllers;

public class StudentController : Controller
{
    #region Fields
    private static string[] existingEmails = new string[]
    {
      "michael.scott@example.com",
      "pam.beesly@example.com",
      "jim.halpert@example.com",
    };
    private readonly IOptionsMonitor<PaymentOptions> _optionsMonitor;
    private readonly IWebHostEnvironment _environment;
    private readonly ILogger<StudentController> _logger;
    #endregion

    public StudentController(
        IOptionsMonitor<PaymentOptions> optionsMonitor,
        IWebHostEnvironment environment,
        ILogger<StudentController> logger)
    {
        _optionsMonitor = optionsMonitor;
        _environment = environment;
        _logger = logger;
    }

    public IActionResult ViewSettings()
    {
        _logger.LogCritical("Hello, Semsem");
        PaymentOptions? value = _optionsMonitor.CurrentValue;
        return View(value);
    }

    #region Create

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateStudentVM studentVM)
    {
        if (!ModelState.IsValid)
        {
            //ModelState.AddModelError("", "Awesome");
            return View(studentVM);
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
    }

    #endregion

    #region Image

    [HttpGet]
    public IActionResult AddImage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddImage(StudentImage model)
    {
        if (model.Image is null)
        {
            ModelState.AddModelError("", "No image sent");
            return View();
        }
        if (model.Image.Length > 1000_000)
        {
            ModelState.AddModelError("", "File is too large");
            return View();
        }

        var allowedExtensions = new string[] { ".png", ".svg" };

        //image.png
        var imageExtension = Path.GetExtension(model.Image.FileName).ToLower();
        if (!allowedExtensions.Contains(imageExtension))
        {
            ModelState.AddModelError("", "not allowed extension");
            return View();
        }

        _logger.LogCritical(_environment.WebRootPath);

        var imagesPath = Path.Combine(_environment.WebRootPath, "Images"); //=> home/desk/Images/(NewGuid)ext
        var newFileName = $"{Guid.NewGuid()}{imageExtension}";
        var filePath = Path.Combine(imagesPath, newFileName);

        using (var stream = System.IO.File.Create(filePath))
        {
            model.Image.CopyTo(stream);
        }
        //filePath
        //newFileName
        //var user = _context.Users.Find(model.Id);
        //user.Image = filePath;
        //_context.SaveChanges();
        return RedirectToAction(actionName: "Index", controllerName: "Home");
    }

    #endregion

    #region Validation

    //[AcceptVerbs("GET", "POST")]
    public IActionResult VerifyEmail(string email)
    {
        if (existingEmails.Contains(email))
        {
            return Json($"{email} is taken.");
        }

        return Json(true);
    }

    #endregion
}
