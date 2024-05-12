using Library_Core.Entities.UserEntities.Concrete;
using Library_DataAccess.SeedData.IdentitySeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.Context.IdentityContext
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserSeedData());
            builder.ApplyConfiguration(new RoleSeedData());
            builder.ApplyConfiguration(new IdentityUserRoleSeedData());
        }
    }
}
