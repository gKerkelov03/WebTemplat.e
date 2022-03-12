using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Template.Data.Models;

namespace Template.Web.Pages
{
    public class RegisterPage : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly IEmailSender _emailSender;

        public RegisterPage(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IUserStore<IdentityUser> userStore, IUserEmailStore<IdentityUser> emailStore, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = emailStore;
            _emailSender = emailSender;
        }

        public void OnGet()
        {
        }
    }
}
