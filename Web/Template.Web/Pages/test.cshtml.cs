using Microsoft.AspNetCore.Mvc.RazorPages;
using Template.Services.Contracts;

namespace Template.Web
{
    public class IndexModel : PageModel
    {
        private IRandomService randomService;
        public IndexModel(IRandomService randomService)
        {
            this.randomService = randomService;
        }

        public void OnGet()
        {
        }
    }
}
