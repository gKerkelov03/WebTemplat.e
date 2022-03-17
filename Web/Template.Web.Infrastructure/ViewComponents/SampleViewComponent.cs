﻿namespace Template.Web.Infrastructure.ViewComponents;

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template.Services.Contracts;

public class SampleViewComponent : ViewComponent
{
    private readonly IRandomService randomService;
    public SampleViewComponent(IRandomService dataService) => this.randomService = dataService;    

    public async Task<IViewComponentResult> InvokeAsync(string name)
    {
        int messageId = this.randomService.Next();

        this.ViewData["Message"] = messageId + " hello from view component";
        this.ViewData["Name"] = name;

        return View();
    }
}

