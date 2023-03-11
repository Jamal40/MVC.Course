using System.ComponentModel.DataAnnotations;

namespace MVC.Day2.Models;

public enum BookStatuses
{
    [Display(Name = "Under Preparing")]
    UnderPreparing,
    Finished,
    Published
}