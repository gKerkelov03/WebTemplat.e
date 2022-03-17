#region Usings
using CloudinaryDotNet;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Template.Data;
using Template.Data.Models;
using Template.Data.Seeding;
using Template.Services.Mapping;
using Template.Web.ViewModels;
using System.Reflection;
using Template.Web.BindingModels;
using Template.Services.Models;
using Template.Web.Infrastructure.Extensions;
using System.Security.Claims;
#endregion

var builder = WebApplication.CreateBuilder(args);

var cloudinaryUtility = new Cloudinary(
    new Account(
        builder.Configuration["Cloudinary:CloudName"],
        builder.Configuration["Cloudinary:ApiKey"],
        builder.Configuration["Cloudinary:ApiSecret"]
    )
);

AutoMapperConfig.RegisterMappings(
    typeof(ErrorViewModel).GetTypeInfo().Assembly,
    typeof(LoginBindingModel).GetTypeInfo().Assembly,
    typeof(LoginServiceModel).GetTypeInfo().Assembly
);

#region Configure Services
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services
    .AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.IdentityOptions)
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddResponseCaching();
builder.Services.AddResponseCompression(options => options.EnableForHttps = true);

builder.Services.AddConventionalServices();
builder.Services.AddTransient<Cloudinary, Cloudinary>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#endregion

var app = builder.Build();

#region Seed Data

using var serviceScope = ((IApplicationBuilder)app).ApplicationServices.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

if (app.Environment.IsDevelopment())
{
    dbContext.Database.Migrate();
}

new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();

#endregion

#region Configure Pipeline

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.MapRazorPages();

#endregion

app.Run();


//builder.Services.AddAuthentication().AddCookie();
