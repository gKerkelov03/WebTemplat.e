namespace Template.Web.Infrastructure.Pages.Account;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Template.Data.Models;

public class LoginPage : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LoginPage(SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }        

    public async Task OnGetAsync(bool SimulateSignUpButtonClick)
    {
        ViewData["SimulateSignUpButtonClick"] = SimulateSignUpButtonClick;
    }

    //public async Task<IActionResult> OnPostAsync()
    //{
    //}
}
