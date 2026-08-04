using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MVCBasicsAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Book> books = new List<Book>();
        public IActionResult Index()
        {
            //if(books == null)
            //{
            //    books ??= new List<Book>();
            //}
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                //books ??= new List<Book>();
                //books.Add(book);
                //var jsonBookList = JsonSerializer.Serialize(books);
                //var bookListSession = HttpContext.Session.GetString("jsonBookList");
                //var bookSession = HttpContext.Session.GetString("bookListSession");
                return View();
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult _BooksPartial()
        {
            return PartialView(books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static string AddBook(Book book)
        {
            //HttpContext.Session.
            //books ??= new List<Book>();
            if(!books.Contains(book))
            {
                books.Add(book);
            }

            
            //var JsonBookList = JsonSerializer.Serialize(books);
            //var JsonSessionBookList = HttpContext.Session.GetString(JsonBookList);

            return "Create";
        }
    }
}
