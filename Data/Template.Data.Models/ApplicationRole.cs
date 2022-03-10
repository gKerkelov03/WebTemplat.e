using System;
using Microsoft.AspNetCore.Identity;

namespace Template.Data.Models
{

    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole(string name) : base(name)
            => this.Id = Guid.NewGuid().ToString();
    }
}
