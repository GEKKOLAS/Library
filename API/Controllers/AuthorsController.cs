using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly LibraryDbContext _context;

        public AuthorsController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: AuthorsController
        public async Task<IActionResult> List()
        {
           // return View(await _context.Authors.ToListAsync());
           AuthorListViewModel authorListViewModel = new AuthorListViewModel(await _context.Authors.ToListAsync());
           return View(authorListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            if (ModelState.IsValid)
                try
                {
                    _context.Add(author);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Author created successfully";
                    return RedirectToAction(nameof(List));
                }
                catch
                {
                    ModelState.AddModelError(String.Empty, "Unable to save changes.");
                }
            return View(author);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Author author)
        {
            if (id != author.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(author);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Author updated successfully";
                    return RedirectToAction("List");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(ex.Message, "Unable to save changes.");
                }
            }
            return View(author);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Authors == null)

            {
                return NotFound();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            try
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
                TempData["AlertMessage"] = "Author deleted successfully";

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "Unable to save changes.");

            }

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _context.Authors.ToListAsync();
            var authorViewModel = new AuthorListViewModel(authors);
            return View(authorViewModel);
        }
    }
}
