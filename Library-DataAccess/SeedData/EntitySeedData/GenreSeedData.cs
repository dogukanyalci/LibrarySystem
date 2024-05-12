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
    public class GenreSeedData : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData
                (

                new Genre
                {
                    Id = 1,
                    Name = "Story"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Novel"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Poem"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Drama"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Comedy"
                },
                new Genre
                {
                    Id = 6,
                    Name = "Tragedy"
                },
                new Genre
                {
                    Id = 7,
                    Name = "Fiction"
                },
                new Genre
                {
                    Id = 8,
                    Name = "Non-Fiction"
                },
                new Genre
                {
                    Id = 9,
                    Name = "Fantasy"
                },
                new Genre
                {
                    Id = 10,
                    Name = "Science Fiction"
                },
                new Genre
                {
                    Id = 11,
                    Name = "Mystery"
                },
                new Genre
                {
                    Id = 12,
                    Name = "Horror"
                },
                new Genre
                {
                    Id = 13,
                    Name = "Romance"
                },
                new Genre
                {
                    Id = 14,
                    Name = "Biography"
                },
                new Genre
                {
                    Id = 15,
                    Name = "Autobiography"
                },
                new Genre
                {
                    Id = 16,
                    Name = "Memoir"
                },
                new Genre
                {
                    Id = 17,
                    Name = "Self-Help"
                },
                new Genre
                {
                    Id = 18,
                    Name = "History"
                },
                new Genre
                {
                    Id = 19,
                    Name = "Travel"
                },
                new Genre
                {
                    Id = 20,
                    Name = "Cooking"
                },
                new Genre
                {
                    Id = 21,
                    Name = "Art"
                },

                new Genre
                {
                    Id = 22,
                    Name = "Photography"
                },
                new Genre
                {
                    Id = 23,
                    Name = "Children"
                },
                new Genre
                {
                    Id = 24,
                    Name = "Young Adult"
                },
                new Genre
                {
                    Id = 25,
                    Name = "Adult"
                },
                new Genre
                {
                    Id = 26,
                    Name = "Science"
                },
                new Genre
                {
                    Id = 27,
                    Name = "Mathematics"
                },
                new Genre
                {
                    Id = 28,
                    Name = "Physics"
                },
                new Genre
                {
                    Id = 29,
                    Name = "Chemistry"
                },
                new Genre
                {
                    Id = 30,
                    Name = "Biology"
                },
                new Genre
                {
                    Id = 31,
                    Name = "Astronomy"
                },
                new Genre
                {
                    Id = 32,
                    Name = "Geology"
                },
                new Genre
                {
                    Id = 33,
                    Name = "Meteorology"
                },
                new Genre
                {
                    Id = 34,
                    Name = "Psychology"
                },
                new Genre
                {
                    Id = 35,
                    Name = "Sociology"
                },
                new Genre
                {
                    Id = 36,
                    Name = "Philosophy"
                },
                new Genre
                {
                    Id = 37,
                    Name = "Religion"
                },
                new Genre
                {
                    Id = 38,
                    Name = "Mythology"
                },
                new Genre
                {
                    Id = 39,
                    Name = "Folklore"
                },
                new Genre
                {
                    Id = 40,
                    Name = "Fairy Tale"
                },
                new Genre
                {
                    Id = 41,
                    Name = "Legend"
                }
                );
        }
    }
}
