namespace Template.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    public IActionResult Index() => View();
}
