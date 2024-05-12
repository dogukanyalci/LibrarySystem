using Library_Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.SeedData.EntitySeedData
{
    public class UsersSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                    new User
                    {
                            AppUserID = "9724a95e-5584-4034-8bc3-6eb332adccb7",
                            FirstName = "John",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "johndoe",
                            Email = "johndoe@test.com"
                    },
                    new User
                    {
                            AppUserID = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027e",
                            FirstName = "Jane",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "janedoe",
                            Email = "janedoe@test.com"
                    },
                    new User
                    {
                            AppUserID = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027f",
                            FirstName = "Jack",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "jackdoe",
                            Email = "jackdoe@test.com"
                    }
                );
        }
    }
}
