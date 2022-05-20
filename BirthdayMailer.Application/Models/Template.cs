namespace BirthdayMailer.Application.Models;

public class Template
{
    public string TemplateHTML { get; set; }

    public Template(string templateHTML)
    {
        TemplateHTML = templateHTML;
    }
}
