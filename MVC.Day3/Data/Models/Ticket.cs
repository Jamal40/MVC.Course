﻿using System.ComponentModel.DataAnnotations;

namespace MVC.Day3.Data.Models;

public class Ticket
{
    public int Id { get; set; }
    
    [Required]
    public string Title { get; set; }= string.Empty;
    
    [Required]
    public string Description { get; set; }= string.Empty;

    public Severity Severity { get; set; }
}
