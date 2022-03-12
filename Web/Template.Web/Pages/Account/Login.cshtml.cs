using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Template.Data.Models;
using Template.Services.Contracts;

namespace Template.Web.Pages
{
    public class LoginPage : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginPage(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }        

        public async Task OnGetAsync()
        {
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //}
    }
}
