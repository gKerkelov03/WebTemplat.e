using Microsoft.AspNetCore.Mvc.RazorPages;
using Template.Services.Contracts;

namespace Template.Web
{
    public class TestPage : PageModel
    {
        private IRandomService randomService;
        public TestPage(IRandomService randomService)
        {
            this.randomService = randomService;
        }

        public void OnGet()
        {
        }
    }
}
