using Library_Core.Entities.UserEntities.Concrete;
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
    public class UserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var admin = new AppUser
            {
                Id = "9724a95e-5584-4034-8bc3-6eb332adccb7",
                FirstName = "Admin",
                LastName = "Admin",
                BirthDate = new DateTime(1999, 01, 01),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var user = new AppUser
            {
                Id = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027e",
                FirstName = "User",
                LastName = "User",
                BirthDate = new DateTime(1999, 01, 01),
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@test.com",
                NormalizedEmail = "USER@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            builder.HasData(admin, user);
        }
    }
}
