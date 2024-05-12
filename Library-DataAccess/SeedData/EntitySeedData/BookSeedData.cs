using Library_Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccess.SeedData.EntitySeedData
{
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                    new Book
                    {
                        Id = 1,
                        Name = "Harry Potter and the Philosopher’s Stone",
                        Description = "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.",
                        AuthorId = 1,
                        GenreId = 1,
                        PageCount = 223,
                        PublishYear = 1997,
                        PublisherId = 1,
                        BorrowedCount = 0,
                        StockCount = 10,
                        Rating = 5,
                        Language = "English",
                        ImageUrl= "https://images-na.ssl-images-amazon.com/images/I/51UoqRAxwEL._SX331_BO1,204,203,200_.jpg",
                    },
                    new Book
                    {
                        Id = 2,
                        Name = "Harry Potter and the Chamber of Secrets",
                        Description = "The Dursleys were so mean and hideous that summer that all Harry Potter wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange, impish creature named Dobby who says that if Harry Potter returns to Hogwarts, disaster will strike.",
                        AuthorId = 1,
                        GenreId = 1,
                        PageCount = 251,
                        PublishYear = 1998,
                        PublisherId = 1,
                        BorrowedCount = 0,
                        StockCount = 10,
                        Rating = 5,
                        Language = "English",
                        ImageUrl= "https://images-na.ssl-images-amazon.com/images/I/51UoqRAxwEL._SX331_BO1,204,203,200_.jpg",
                    },
                    new Book
                    {
                        Id = 3,
                        Name = "It",
                        Description = "To the children, the town was their whole world. To the adults, knowing better, Derry, Maine was just their home town: familiar, well-ordered for the most part. A good place to live.",
                        AuthorId = 2,
                        GenreId = 2,
                        PageCount = 1138,
                        PublishYear = 1986,
                        PublisherId = 2,
                        BorrowedCount = 0,
                        StockCount = 10,
                        Rating = 5,
                        Language = "English",
                        ImageUrl = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-173540-IT.jpg?w=1280",
                    },
                    new Book
                    {
                        Id = 4,
                        Name = "The Shining",
                        Description = "Jack Torrance’s new job at the Overlook Hotel is the perfect chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he’ll have plenty of time to spend reconnecting with his family and working on his writing.",
                        AuthorId = 2,
                        GenreId = 2,
                        PageCount = 447,
                        PublishYear = 1977,
                        PublisherId = 2,
                        BorrowedCount = 0,
                        StockCount = 10,
                        Rating = 5,
                        Language = "English",
                        ImageUrl = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-173546-The-Shining.jpg?w=1280",
                    }
                );
        }
    }
}
