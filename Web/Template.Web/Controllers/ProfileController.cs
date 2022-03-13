using Microsoft.AspNetCore.Mvc;

namespace Template.Web.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
