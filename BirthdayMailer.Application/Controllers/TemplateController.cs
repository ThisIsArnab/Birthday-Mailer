using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

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