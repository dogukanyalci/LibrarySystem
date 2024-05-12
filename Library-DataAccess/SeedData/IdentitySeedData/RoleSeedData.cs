using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.SeedData.IdentitySeedData
{
    public class RoleSeedData : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var admin = new IdentityRole
            {
                Id = "60ea3719-b432-493f-87f7-f741092794dc",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            var user = new IdentityRole
            {
                Id = "5242e84c-924f-46e4-9ab0-52472155340f",
                Name = "User",
                NormalizedName = "USER"
            };

            builder.HasData(admin, user);
        }
    }
}
