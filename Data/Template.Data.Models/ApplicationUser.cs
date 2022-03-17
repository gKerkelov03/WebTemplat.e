﻿namespace Template.Data.Models;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser<string>
{
    public ApplicationUser()
    {
        this.Id = Guid.NewGuid().ToString();
        this.Roles = new HashSet<IdentityUserRole<string>>();
        this.Claims = new HashSet<IdentityUserClaim<string>>();
        this.Logins = new HashSet<IdentityUserLogin<string>>();
    }

    public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

    public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    public string Test { get; set; }

    public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
}
