namespace Library_WEB.Models.ViewModels
{
    public class BookVM
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


    }
}
