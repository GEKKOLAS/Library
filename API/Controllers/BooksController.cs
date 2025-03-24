using API.ViewModel;
using Core.Models;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly IListService _listService;
        private readonly ILoadImage _loadImage;
        private readonly IUserService _userService;

        public BooksController(LibraryDbContext context, IListService listService, ILoadImage loadImage, IUserService userService)
        {
            _context = context;
            _listService = listService;
            _loadImage = loadImage;
            _userService = userService;
        }

        public async Task<IActionResult> List()
        {
            var books = await _context.Books.Include(l => l.Author).ToListAsync();
            var authors = await _context.Authors.ToListAsync();
            var bookListViewModel = new BookListViewModel(books, authors);
            return View(bookListViewModel);
        }

        public async Task<IActionResult> Create()
        {
            var authors = await _context.Authors.ToListAsync();
            var book = new Book
            {
                Title = "Default Title",
                Author = authors.FirstOrDefault()
            };
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Books.AddAsync(book);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("List");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            var authors = await _context.Authors.ToListAsync();
            book.Author = authors.FirstOrDefault();
            return View(book);
        }

        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.ToListAsync();
            var authors = await _context.Authors.ToListAsync();
            var bookListViewModel = new BookListViewModel(books, authors);
            return View(bookListViewModel);
        }
    }
}