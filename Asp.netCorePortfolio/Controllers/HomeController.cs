using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Asp.netCorePortfolio.Models;
using EmailService;

namespace Asp.netCorePortfolio.Controllers;

public class HomeController : Controller
{
    
    private readonly IEmailSender _emailService;
    private readonly EmailConfiguration _emailConfig;

    public HomeController(IEmailSender emailService, EmailConfiguration emailConfig)
    {
        _emailService = emailService;
        _emailConfig = emailConfig;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}