namespace Template.Web.Infrastructure.Pages.Account;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Template.Data.Models;

public class LogoutPage : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LogoutPage(SignInManager<ApplicationUser> signInManager) => _signInManager = signInManager;   

    public async Task<IActionResult> OnPost(string returnUrl = null)
    {
        await _signInManager.SignOutAsync();

        if (returnUrl != null)
        {
            return LocalRedirect(returnUrl);
        }
        else
        {
            return RedirectToPage();
        }
    }
}
