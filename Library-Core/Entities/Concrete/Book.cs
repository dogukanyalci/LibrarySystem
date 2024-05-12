using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int PageCount { get; set; }
        public int StockCount { get; set; }
        public int BorrowedCount { get; set; }
        public int RatingId { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public DateTime PublishYear { get; set; }
        public string? ImagePath { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}
