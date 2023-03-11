using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MVC.Day6.Models.ViewModels;

public record CreateStudentVM
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must enter a password")]
    [Display(Name = "Password Confirmation")]
    [Compare(nameof(Password))]
    public string ConfirmPasswod { get; set; } = string.Empty;

    [EmailAddress]
    [Remote(action: "VerifyEmail", controller: "Student")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1}")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Range(1, 100, ErrorMessage = "{0} must be betwen {1} and {2}")]
    [Display(Name = "Student's Mark")]
    public int Mark { get; set; }

    [Required]
    public string Password { get; set; } = string.Empty;

    [Phone]
    [RegularExpression("01[0125][0-9]{8}")]
    public string Phone { get; set; } = string.Empty;
}