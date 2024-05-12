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
    public class IdentityUserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "60ea3719-b432-493f-87f7-f741092794dc",
                        UserId = "9724a95e-5584-4034-8bc3-6eb332adccb7"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "5242e84c-924f-46e4-9ab0-52472155340f",
                        UserId = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027e"
                    }
                );
        }
    }
}
