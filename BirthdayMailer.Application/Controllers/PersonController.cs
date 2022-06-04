using System.ComponentModel.DataAnnotations;
using BirthdayMailer.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

/**
 *  The PersonController is reponsible for adding, updating or deleting people from the database.
 */
[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// NOTE: Validation of email should be done in Action method instead of route constraint.
    /// Adding Regex as route constraint increases time for route resolution.
    /// </summary>
    [HttpGet("getPerson/{email}", Name = "getPerson")]
    public ActionResult<Person> GetPerson([EmailAddress] string email)
    {
        // TODO: Remove test response
        return Ok(new Person("", "", email, 0, 0, DateTime.Now, true));
    }

    /// <summary>
    /// NOTE: Only :int constraint is added to route other date related validation should be performed by Action method.
    /// </summary>
    [HttpGet("getPeople/{day:int}/{month:int}", Name = "getPeopleByBirthDay")]
    public ActionResult<IEnumerable<Person>> GetPeopleByBirthDay(int day, int month)
    {
        // TODO: Remove test response
        return Ok(new Person[] { new Person("", "", "", day, month, DateTime.Now, true)});
    }

    [HttpPost("addPerson", Name = "addPerson")]
    public IActionResult AddPerson([FromBody] Person person)
    {
        return Ok(person);
    }

    [HttpPost("updatePerson", Name = "updatePerson")]
    public IActionResult UpdatePerson([FromBody] Person person)
    {
        return Ok(person);
    }
}
