using AutoMapper;
using Library_DataAccess.Services.Interface;
using Library_WEB.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Library_Core.Entities.Abstract;
using Microsoft.AspNetCore.Authorization;
using Library_Core.DTO_s.BookDTO;
using System.Security.Claims;
using Library_Core.Entities.Concrete;

namespace Library_WEB.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly IUserBookRepository _userBookRepository;

        public BooksController(IBookRepository bookRepository, IAuthorRepository authorRepository, IMapper mapper, IUserBookRepository userBookRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
            _userBookRepository = userBookRepository;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepository.GetFilteredListAsync
                (
                    select: x => new BookVM
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        AuthorId = x.AuthorId,
                        GenreId = x.GenreId,
                        PublisherId = x.PublisherId,
                        PublishYear = x.PublishYear,
                        PageCount = x.PageCount,
                        StockCount = x.StockCount,
                        BorrowedCount = x.BorrowedCount,
                        Rating = x.Rating,
                        Language = x.Language,
                        ImageUrl = x.ImageUrl,
                    },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.Name)
                );
            return View(books);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> BookDetails(int id)
        {
            if (id > 0)
            {
                var book = await _bookRepository.GetByIdAsync(id);
                if (book != null)
                {
                    var model = _mapper.Map<BookDetailsDTO>(book);
                    return View(model);
                }
            }
                TempData["Error"] = "Kitap Bulunamadı!";
                return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> FavoriteBook(int bookId)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var book = await _bookRepository.GetByIdAsync(bookId);

            if (book == null)
            {
                return NotFound();
            }

            var userBook = new UserBook
            {
                UserId = userId,
                BookId = bookId,
                IsFavorited = true
            };

            await _userBookRepository.AddAsync(userBook);

            return RedirectToAction("Details", "Books", new { id = bookId });
        }
    }
}
