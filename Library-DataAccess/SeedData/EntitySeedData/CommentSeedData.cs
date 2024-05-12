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
    public class CommentSeedData : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData
                (
                    new Comment
                    {
                        Id = 1,
                        AppUserID = "9724a95e-5584-4034-8bc3-6eb332adccb7",
                        BookId = 1,
                        UserComment = "Great book!",
                        Username = "johndoe"
                    },
                    new Comment
                    {
                        Id = 2,
                        AppUserID = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027e",
                        BookId = 2,
                        UserComment = "I loved it!",
                        Username = "janedoe"
                    },
                    new Comment
                    {
                        Id = 3,
                        AppUserID = "e13ba7bd-4a2c-418d-bd4b-e4faf14d027f",
                        BookId = 3,
                        UserComment = "I couldn't put it down!",
                        Username = "jackdoe"
                    }
                );
        }
    }
}
