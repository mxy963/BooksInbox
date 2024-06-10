using Books_Inbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Books_Inbox.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            IEnumerable<Book> objBookList = _db.Books.ToList();
            return View(objBookList);
        }
        public IActionResult Detail(int id)
        {
            var book = _db.Books.FirstOrDefault(p => p.ID == id);

            if (book == null)
                return NotFound();

            var Writer = _db.Writers.FirstOrDefault(c => c.Name == book.WriterName);
  

            var viewModel = new BookDetailViewModel
            {
                Writer = Writer,
                Book = book
            };
            return View(viewModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}