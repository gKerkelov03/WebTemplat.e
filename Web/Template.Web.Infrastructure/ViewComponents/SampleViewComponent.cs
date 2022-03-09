using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template.Services.Contracts;

namespace Template.Web.Infrastructure.ViewComponents
{
    [ViewComponent(Name = "HelloWorld")]
    public class HelloWorldViewComponent : ViewComponent
    {
        private readonly IRandomService dataService;
        public HelloWorldViewComponent(IRandomService dataService)
        {
            this.dataService = dataService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            int helloMessage = this.dataService.Next();

            this.ViewData["Message"] = helloMessage;
            this.ViewData["Name"] = name;

            return View();
        }
    }

}
