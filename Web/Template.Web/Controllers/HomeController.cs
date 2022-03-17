namespace Template.Web.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template.Web.ViewModels;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index() => View();        

    public IActionResult About() => View();       

    public IActionResult Dashboard() => View();

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });        
}
