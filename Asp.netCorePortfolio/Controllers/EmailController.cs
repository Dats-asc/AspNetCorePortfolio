using EmailService;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCorePortfolio.Controllers;

public class EmailController : Controller
{
    
    private readonly IEmailSender _emailService;
    private readonly EmailConfiguration _emailConfig;

    public EmailController(IEmailSender emailService, EmailConfiguration emailConfig)
    {
        _emailService = emailService;
        _emailConfig = emailConfig;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult SendEmail(
        string nameContact, 
        string emailContact, 
        string subjectContact, 
        string messageContact)
    {
        var message = new Message(new[] {_emailConfig.From}, $"Contact form: {subjectContact}",
            $"Name: {nameContact}\nEmail: {emailContact}\n\n{messageContact}");
        _emailService.SendEmail(message);

        return Ok("sent successfully");
    }
}