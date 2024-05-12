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
                        BookId = 1,
                        UserComment = "Great book!",
                        Username = "johndoe"
                    },
                    new Comment
                    {
                        Id = 2,
                        BookId = 2,
                        UserComment = "I loved it!",
                        Username = "janedoe"
                    },
                    new Comment
                    {
                        Id = 3,
                        BookId = 3,
                        UserComment = "I couldn't put it down!",
                        Username = "jackdoe"
                    }
                );
        }
    }
}
