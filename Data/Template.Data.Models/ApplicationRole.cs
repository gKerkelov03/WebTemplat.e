using System;
using Template.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace Template.Data.Models
{

    public class ApplicationRole : IdentityRole
    {        
        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
