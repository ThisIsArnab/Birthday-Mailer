using System.ComponentModel.DataAnnotations;
using BirthdayMailer.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

/// <summary>
/// The PersonController is reponsible for adding, updating or deleting people from the database.
/// Default API convention applied to controller. Web API conventions are substitue for decorating
/// indivisual actions with [ProducesResponseType]
/// </summary>
/// <see href="https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/conventions?view=aspnetcore-6.0">Using Web Api conventions</see>
[ApiController]
[Route("[controller]")]
[ApiConventionType(typeof(DefaultApiConventions))]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Finds the persion with given <paramref name="email"/><br />
    /// NOTE: Favor model validation attributes over route constraint for email validation.
    /// Adding Regex as route constraint increases time for route resolution.
    /// </summary>
    /// <param name="email">Email id of the person to search</param>
    [HttpGet("{email}", Name = nameof(PersonController.GetPerson))]
    public ActionResult<Person> GetPerson([EmailAddress] string email)
    {
        // TODO: Remove test response
        return Ok($"Email : {email}");
    }

    /// <summary>
    /// Finds list of people whose birth day and Month falls on given <paramref name="day"/> and <paramref name="month"/><br />
    /// NOTE: Only :int constraint is added to route.
    /// Other date related validation should be performed by Action method.
    /// </summary>
    [HttpGet("{day:int}/{month:int}", Name = nameof(PersonController.GetPersons))]
    public ActionResult<IEnumerable<Person>> GetPersons([Range(1, 31)]int day, [Range(1, 12)]int month)
    {
        // TODO: Validate correct day of Month e.g. (30, 2)❌
        // TODO: Remove test response
        return Ok($"{day} / {month}");
    }

    /// <summary>
    /// Add a new person in database.
    /// </summary>
    /// <param name="person"></param>
    [HttpPost(Name = nameof(PersonController.CreatePerson))]
    public IActionResult CreatePerson([FromBody] Person person)
    {
        return Ok(person);
    }

    /// <summary>
    /// Updates a existing person in database
    /// </summary>
    /// <param name="person">Person Model object</param>
    [HttpPut(Name = nameof(PersonController.UpdatePerson))]
    public IActionResult UpdatePerson([FromBody] Person person)
    {
        return Ok(person);
    }

    /// <summary>
    /// Removes the person with given <paramref name="emailId"/> from database.
    /// </summary>
    /// <param name="emailId">Email id of ther person to delete</param>
    [HttpDelete("{email}", Name=nameof(PersonController.DeletePerson))]
    public IActionResult DeletePerson([EmailAddress] string emailId)
    {
        return Ok(emailId);
    }
}
