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
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                new Book
                {
                    Id = 1,
                    Name = "Kürk Mantolu Madonna",
                    Description = "Kürk Mantolu Madonna, Sabahattin Ali'nin 1943 yılında yayımlanan romanıdır. Roman, bir aşk hikâyesi etrafında şekillenir. Romanın başkahramanı Raif Efendi, İstanbul'da yaşayan bir memurdur. Raif Efendi, bir gün trenle yaptığı bir yolculuk sırasında, yanına oturan genç bir kadın olan Maria Puder'e aşık olur. Maria Puder, Raif Efendi'nin hayatına girdikten sonra, onun hayatını tamamen değiştirir.",
                    AuthorId = 1,
                    GenreId = 1,
                    PublisherId = 1,
                    PublishYear = new DateTime(2010, 1, 1),
                    Rating = 5,
                    PageCount = 200,
                    StockCount = 100,
                    BorrowedCount = 0,
                    IsFavorited = false,
                    ImagePath = "kürk-mantolu-madonna.jpg",
                    Language = "Türkçe",
                }
                );
            builder.HasData
                (
                               new Book
                               {
                    Id = 2,
                    Name = "İçimizdeki Şeytan",
                    Description = "İçimizdeki Şeytan, Sabahattin Ali'nin 1940 yılında yayımlanan romanıdır. Roman, bir aşk hikâyesi etrafında şekillenir. Romanın başkahramanı Raif Efendi, İstanbul'da yaşayan bir memurdur. Raif Efendi, bir gün trenle yaptığı bir yolculuk sırasında, yanına oturan genç bir kadın olan Maria Puder'e aşık olur. Maria Puder, Raif Efendi'nin hayatına girdikten sonra, onun hayatını tamamen değiştirir.",
                    AuthorId = 1,
                    GenreId = 1,
                    PublisherId = 1,
                    PublishYear = new DateTime(2010, 1, 1),
                    Rating = 5,
                    PageCount = 200,
                    StockCount = 100,
                    BorrowedCount = 0,
                    IsFavorited = false,
                    ImagePath = "icimizdeki-seytan.jpg",
                    Language = "Türkçe",
                }
                                              );
        }
    }
}
