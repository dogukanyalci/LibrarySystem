using AutoMapper;
using Library_Core.DTO_s.CommentDTO;
using Library_Core.Entities.Abstract;
using Library_Core.Entities.Concrete;
using Library_DataAccess.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Library_WEB.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;

        public CommentsController(ICommentRepository commentRepository, IMapper mapper, IUserRepository userRepository, IBookRepository bookRepository)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var comments = _commentRepository.GetFilteredListAsync
                (
                    select: x => new CommentsVM
                    {
                        BookName = x.Book.Name,
                        UserComment = x.UserComment,
                        BookId = x.BookId,
                        UserName = x.User.UserName
                    },
                    where: x => x.Status != Status.Passive
                );
            return View(comments);
        }

        [Authorize(Roles = "Admin, User")]
        public IActionResult AddComment() => View();

        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> AddComment(AddCommentDTO model)
        {

            if (ModelState.IsValid)
            {
                var comment = new Comment
                {
                    BookId = model.BookId,
                    Username = model.Username,
                    UserComment = model.UserComment,
                    UserId = (int)model.UserId
                };
                await _commentRepository.AddAsync(comment);
                TempData["Success"] = "Your comment is saved.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Please follow the rules below!";
            return View(model);
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            if (id > 0)
            {
                var comment = await _commentRepository.GetByIdAsync(id);
                if (comment != null)
                {
                    await _commentRepository.DeleteAsync(comment);
                    TempData["Success"] = "Comment deleted successfully";
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Comment not found!";
            return RedirectToAction("Index");
        }
    }
}
