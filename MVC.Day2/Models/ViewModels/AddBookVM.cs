using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVC.Day2.Models.ViewModels
{
    public class AddBookVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "User's Email")]
        [MaxLength(50, ErrorMessage = "User's mail is too long")]
        [MinLength(5, ErrorMessage = "User's mail is too short")]
        public string UserEmail { get; set; } = string.Empty;

        [Required]
        [Display(Name = "User's Password")]
        [MaxLength(20, ErrorMessage = "User's password is too long")]
        [MinLength(3, ErrorMessage = "User's password is too short")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;

        [Display(Name = "Should be reviewd?")]
        public bool ShouldBeReviewd { get; set; }  

        public int CountryId { get; set; } //=> Select


        [Display(Name = "Book Status")]
        public BookStatuses Status { get; set; }

        public IEnumerable<string> Reviewers { get; set; } = new HashSet<string>(); //=> MultiSelect

        public string ReviewersString { get; set; } = string.Empty;

        #region Helpers

        public static List<SelectListItem> CountriesList { get; set; } = new()
        {
            new("Egypt", "1"),
            new("KSA", "2"),
            new("UAE", "3"),
            new("USA", "4"),
        };

        public static List<SelectListItem> ReviewersList { get; set; } = new()
        {
            new("John", "1"),
            new("Jimmy", "2"),
            new("Joe", "3"),
            new("Doe", "4"),
        };

        #endregion
    }
}