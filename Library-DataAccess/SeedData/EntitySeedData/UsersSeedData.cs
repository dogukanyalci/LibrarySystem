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
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "johndoe",
                            Email = "johndoe@test.com",
                            Password = "123"
                    },
                    new User
                    {
                            Id = 2,
                            FirstName = "Jane",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "janedoe",
                            Email = "janedoe@test.com",
                            Password = "123"

                    },
                    new User
                    {
                            Id = 3,
                            FirstName = "Jack",
                            LastName = "Doe",
                            BirthDate = new DateTime(1999, 01, 01),
                            UserName = "jackdoe",
                            Email = "jackdoe@test.com",
                            Password = "123"

                    }
                );
        }
    }
}
