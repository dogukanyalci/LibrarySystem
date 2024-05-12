namespace Library_WEB.Models.ViewModels
{
    public class LibraryVM
    {
        public List<BookVM> Books { get; set; }
        public List<AuthorVM> Authors { get; set; }
        public List<PublisherVM> Publishers { get; set; }
        public List<GenreVM> Genres { get; set; }

    }
}
