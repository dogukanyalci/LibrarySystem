using Library_Core.Entities.Concrete;
using Library_DataAccess.SeedData.EntitySeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorPublisher> AuthorPublishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserBook>()
                .HasKey(x => new { x.UserId, x.BookId });

            modelBuilder.Entity<AuthorPublisher>()
                .HasKey(x => new { x.AuthorId, x.PublisherId });

            modelBuilder.ApplyConfiguration(new AuthorPublisherSeedData());
            modelBuilder.ApplyConfiguration(new AuthorSeedData());
            modelBuilder.ApplyConfiguration(new BookSeedData());
            modelBuilder.ApplyConfiguration(new CommentSeedData());
            modelBuilder.ApplyConfiguration(new GenreSeedData());
            modelBuilder.ApplyConfiguration(new PublisherSeedData());
            modelBuilder.ApplyConfiguration(new UsersSeedData());



        }
    }
}
