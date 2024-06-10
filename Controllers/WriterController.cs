using Books_Inbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Books_Inbox.Controllers
{
    public class WriterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public WriterController(ApplicationDbContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            IEnumerable<Writer> objWriterList = _db.Writers.ToList();
            return View(objWriterList);
        }
        public IActionResult Detail(int id)
        {
            var writer = _db.Writers.FirstOrDefault(p => p.ID == id);

            if (writer == null)
                return NotFound();

            var book = _db.Books.FirstOrDefault(c => c.WriterName == writer.Name);

            //if (Writer == null)
            //    return NotFound(); // Handle the case where the category is not found

            var viewModel = new WriterDetailViewModel
            {
                Writer = writer,
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