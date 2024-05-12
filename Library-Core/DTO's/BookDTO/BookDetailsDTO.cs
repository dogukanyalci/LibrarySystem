using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.BookDTO
{
    public class BookDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int PublisherId { get; set; }
        public int PublishYear { get; set; }
        public int PageCount { get; set; }
        public int StockCount { get; set; }
        public int BorrowedCount { get; set; }
        public int Rating { get; set; }
        public string Language { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsFavorited { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }
    }
}
