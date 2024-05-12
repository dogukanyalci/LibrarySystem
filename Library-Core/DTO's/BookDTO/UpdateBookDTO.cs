using Library_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.BookDTO
{
    public class UpdateBookDTO
    {
        public int Id { get; set; }
        [Display(Name = "Kitap Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Yazar")]
        public int AuthorId { get; set; }
        [Display(Name = "Tür")]
        public int GenreId { get; set; }
        [Display(Name = "Yayınevi")]
        public int PublisherId { get; set; }
        [Display(Name = "Yayın Yılı")]
        public int PublishYear { get; set; }
        [Display(Name = "Sayfa Sayısı")]
        public int PageCount { get; set; }
        [Display(Name = "Stok Sayısı")]
        public int StockCount { get; set; }
        [Display(Name = "Ödünç Alınma Sayısı")]
        public int BorrowedCount { get; set; }
        [Display(Name = "Puan")]
        public int Rating { get; set; }
        [Display(Name = "Dil")]
        public string Language { get; set; }
        [Display(Name = "Resim Url")]
        public string? ImageUrl { get; set; }
        [Display(Name = "Favori")]
        public bool? IsFavorited { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
