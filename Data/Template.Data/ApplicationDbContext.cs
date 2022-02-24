namespace Template.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using Template.Data.Common;
    using Template.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }              
    }
}
