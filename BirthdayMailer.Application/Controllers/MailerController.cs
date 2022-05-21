using Microsoft.AspNetCore.Mvc;

namespace BirthdayMailer.Application.Controllers;

/**
 *  This controller is used to send email to specific recipients on-demand.
 *  Mostly this will be used for testing purpose.
 */
[ApiController]
[Route("[controller]")]
public class MailerController: ControllerBase
{
    private readonly ILogger<MailerController> _logger;

    public MailerController(ILogger<MailerController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "sendMail")]
    public IActionResult Post()
    {
        return Ok();
    }
}
