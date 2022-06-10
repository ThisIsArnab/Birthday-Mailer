using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BirthdayMailer.Application.Models;

public class Person
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string EmailAddr { get; set; } = null!;

    /// <summary>
    /// Day and Month should be stored as datetime in db for facilitating sorting, integrity and validation.
    /// Store as leap year to include 29th Feb date.
    /// </summary>
    [Required]
    [Range(1, 31)]
    public int DayOfBirth { get; set; }

    [Required]
    [Range(1, 12)]
    public int MonthOfBirth { get; set; }

    public DateTime DateOfJoining { get; set; }

    [BindNever]
    public bool IsActive { get; set; }
}
