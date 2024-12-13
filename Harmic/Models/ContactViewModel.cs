﻿using System.ComponentModel.DataAnnotations;
namespace Harmic.Models;

public class ContactViewModel
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Phone { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    public string? Message { get; set; }
}
