using AutoMapper;
using Library_Core.DTO_s.AuthorDTO;
using Library_Core.DTO_s.BookDTO;
using Library_Core.DTO_s.GenreDTO;
using Library_Core.DTO_s.PublisherDTO;
using Library_Core.Entities.Abstract;
using Library_Core.Entities.Concrete;
using Library_DataAccess.Services.Interface;
using Library_WEB.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library_WEB.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public DashboardController(IBookRepository bookRepository, IAuthorRepository authorRepository, IGenreRepository genreRepository, IPublisherRepository publisherRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _genreRepository = genreRepository;
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

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

            var authors = await _authorRepository.GetFilteredListAsync
                (
                    select: x => new AuthorVM
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description
                    },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.Name)
                );

            var publishers = await _publisherRepository.GetFilteredListAsync
                (
                    select: x => new PublisherVM
                    {
                        Id = x.Id,
                        Name = x.Name
                    },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.Name)
                );
            var genres = await _genreRepository.GetFilteredListAsync
                (
                    select: x => new GenreVM
                    {
                        Id = x.Id,
                        Name = x.Name
                    },
                    where: x => x.Status != Status.Passive,
                    orderBy: x => x.OrderByDescending(z => z.Name)
                );

            var library = new LibraryVM
            {
                Books = books,
                Authors = authors,
                Publishers = publishers,
                Genres = genres
            };


            return View(library);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddBook(AddBookDTO model)
        {
            if(ModelState.IsValid)
            {
                var book = _mapper.Map<Book>(model);
                await _bookRepository.AddAsync(book);
                TempData["Success"] = "Kitap başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateBook(int id)
        {
            if (id > 0)
            {
                var book = await _bookRepository.GetByIdAsync(id);
                if (book != null)
                {
                    var model = _mapper.Map<UpdateBookDTO>(book);
                    return View(model);
                }
            }
            TempData["Error"] = "Kitap Bulunamadı!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateBook(UpdateBookDTO model)
        {
            if (ModelState.IsValid)
            {
                var book = _mapper.Map<Book>(model);
                await _bookRepository.UpdateAsync(book);
                TempData["Success"] = "Kitap başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (id > 0)
            {
                var book = await _bookRepository.GetByIdAsync(id);
                if (book != null)
                {
                    await _bookRepository.DeleteAsync(book);
                    TempData["Success"] = "Kitap başarıyla silindi.";
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Kitap Bulunamadı!";
            return RedirectToAction("Index");
        }

        [Authorize (Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> AddAuthor(AddAuthorDTO model)
        {
            if (ModelState.IsValid)
            {
                var author = _mapper.Map<Author>(model);
                await _authorRepository.AddAsync(author);
                TempData["Success"] = "Yazar başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdateAuthor(int id)
        {
            if (id > 0)
            {
                var author = await _authorRepository.GetByIdAsync(id);
                if (author != null)
                {
                    var model = _mapper.Map<UpdateAuthorDTO>(author);
                    return View(model);
                }
            }
            TempData["Error"] = "Yazar Bulunamadı!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorDTO model)
        {
            if (ModelState.IsValid)
            {
                var author = _mapper.Map<Author>(model);
                await _authorRepository.UpdateAsync(author);
                TempData["Success"] = "Yazar başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            if (id > 0)
            {
                var author = await _authorRepository.GetByIdAsync(id);
                if (author != null)
                {
                    await _authorRepository.DeleteAsync(author);
                    TempData["Success"] = "Yazar başarıyla silindi.";
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Yazar Bulunamadı!";
            return RedirectToAction("Index");
        }

        [Authorize (Roles = "Admin")]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> AddGenre(AddGenreDTO model)
        {
            if (ModelState.IsValid)
            {
                var genre = _mapper.Map<Genre>(model);
                await _genreRepository.AddAsync(genre);
                TempData["Success"] = "Tür başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdateGenre(int id)
        {
            if (id > 0)
            {
                var genre = await _genreRepository.GetByIdAsync(id);
                if (genre != null)
                {
                    var model = _mapper.Map<UpdateGenreDTO>(genre);
                    return View(model);
                }
            }
            TempData["Error"] = "Tür Bulunamadı!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdateGenre(UpdateGenreDTO model)
        {
            if (ModelState.IsValid)
            {
                var genre = _mapper.Map<Genre>(model);
                await _genreRepository.UpdateAsync(genre);
                TempData["Success"] = "Tür başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            if (id > 0)
            {
                var genre = await _genreRepository.GetByIdAsync(id);
                if (genre != null)
                {
                    await _genreRepository.DeleteAsync(genre);
                    TempData["Success"] = "Tür başarıyla silindi.";
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Tür Bulunamadı!";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddPublisher()
        {
            return View();
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> AddPublisher(AddPublisherDTO model)
        {
            if (ModelState.IsValid)
            {
                var publisher = _mapper.Map<Publisher>(model);
                await _publisherRepository.AddAsync(publisher);
                TempData["Success"] = "Yayınevi başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }

        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdatePublisher(int id)
        {
            if (id > 0)
            {
                var publisher = await _publisherRepository.GetByIdAsync(id);
                if (publisher != null)
                {
                    var model = _mapper.Map<UpdatePublisherDTO>(publisher);
                    return View(model);
                }
            }
            TempData["Error"] = "Yayınevi Bulunamadı!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> UpdatePublisher(UpdatePublisherDTO model)
        {
            if (ModelState.IsValid)
            {
                var publisher = _mapper.Map<Publisher>(model);
                await _publisherRepository.UpdateAsync(publisher);
                TempData["Success"] = "Yayınevi başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen kurallara uyunuz.";
            return View(model);
        }
        
        [Authorize (Roles = "Admin")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            if (id > 0)
            {
                var publisher = await _publisherRepository.GetByIdAsync(id);
                if (publisher != null)
                {
                    await _publisherRepository.DeleteAsync(publisher);
                    TempData["Success"] = "Yayınevi başarıyla silindi.";
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Yayınevi Bulunamadı!";
            return RedirectToAction("Index");
        }

    }
}
