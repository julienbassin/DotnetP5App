using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetP5App.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetP5App.Data
{
    public class DotnetP5AppContext : IdentityDbContext<SecureAppUser>
    {
        public DotnetP5AppContext(DbContextOptions<DotnetP5AppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
