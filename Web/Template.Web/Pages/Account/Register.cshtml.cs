using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Template.Data.Models;

namespace Template.Web.Pages
{
    public class RegisterPage : PageModel
    {
        public RegisterPage(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {

        }
        public void OnGet()
        {
        }
    }
}
