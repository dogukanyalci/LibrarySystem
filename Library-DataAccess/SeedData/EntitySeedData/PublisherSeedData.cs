using Library_Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_DataAccess.SeedData.EntitySeedData
{
    public class PublisherSeedData : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData
                (
                    new Publisher { Id = 1, Name = "Penguin Random House" },
                    new Publisher { Id = 2, Name = "HarperCollins" },
                    new Publisher { Id = 3, Name = "Simon & Schuster" },
                    new Publisher { Id = 4, Name = "Hachette Livre" },
                    new Publisher { Id = 5, Name = "Macmillan Publishers" },
                    new Publisher { Id = 6, Name = "Pearson Education" },
                    new Publisher { Id = 7, Name = "Scholastic" },
                    new Publisher { Id = 8, Name = "Cengage Learning" },
                    new Publisher { Id = 9, Name = "Wiley" },
                    new Publisher { Id = 10, Name = "McGraw-Hill Education" },
                    new Publisher { Id = 11, Name = "Houghton Mifflin Harcourt" },
                    new Publisher { Id = 12, Name = "Harlequin Enterprises" },
                    new Publisher { Id = 13, Name = "Bloomsbury Publishing" },
                    new Publisher { Id = 14, Name = "Cambridge University Press" },
                    new Publisher { Id = 15, Name = "Oxford University Press" },
                    new Publisher { Id = 16, Name = "Elsevier" },
                    new Publisher { Id = 17, Name = "Taylor & Francis" },
                    new Publisher { Id = 18, Name = "Springer" },
                    new Publisher { Id = 19, Name = "John Wiley & Sons" },
                    new Publisher { Id = 20, Name = "SAGE Publications" },
                    new Publisher { Id = 21, Name = "Kapra Yayıncılık" },
                    new Publisher { Id = 22, Name = "Doğan Kitap" },
                    new Publisher { Id = 23, Name = "İthaki Yayınları" },
                    new Publisher { Id = 24, Name = "Koridor Yayıncılık" },
                    new Publisher { Id = 25, Name = "Can Yayınları" },
                    new Publisher { Id = 26, Name = "Kırmızı Kedi Yayınevi" },
                    new Publisher { Id = 27, Name = "Pegasus Yayınları" },
                    new Publisher { Id = 28, Name = "İnkılap Kitabevi" },
                    new Publisher { Id = 29, Name = "Everest Yayınları" },
                    new Publisher { Id = 30, Name = "Yapı Kredi Yayınları" },
                    new Publisher { Id = 31, Name = "Metis Yayınları" },
                    new Publisher { Id = 32, Name = "İletişim Yayınları" },
                    new Publisher { Id = 33, Name = "Can Çocuk Yayınları" },
                    new Publisher { Id = 34, Name = "Timaş Yayınları" },
                    new Publisher { Id = 35, Name = "Domingo Yayınevi" },
                    new Publisher { Id = 36, Name = "Kolektif Kitap" },
                    new Publisher { Id = 37, Name = "İş Bankası Kültür Yayınları" },
                    new Publisher { Id = 38, Name = "Remzi Kitabevi" },
                    new Publisher { Id = 39, Name = "Yordam Kitap" },
                    new Publisher { Id = 40, Name = "Liberus" }
                );
        }
    }
}
