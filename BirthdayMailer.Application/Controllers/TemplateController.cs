using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

/**
 *  The TemplateController is reponsible for adding, updating or deleting email templated from the database.
 */
[ApiController]
[Route("[controller]")]
public class TemplateController: ControllerBase
{
    private readonly ILogger<TemplateController> _logger;

    public TemplateController(ILogger<TemplateController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "getTemplate")]
    public string Get()
    {
        return "Template string";
    }
}