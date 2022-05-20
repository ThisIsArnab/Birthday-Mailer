using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "getPerson")]
    public string Get()
    {
        return "sample person";
    }

}
