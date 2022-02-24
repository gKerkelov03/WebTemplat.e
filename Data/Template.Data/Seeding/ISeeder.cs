using System;
using System.Threading.Tasks;

namespace Template.Data.Seeding
{

    public interface ISeeder
    {
        Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
    }
}
