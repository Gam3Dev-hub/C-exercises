using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;

namespace MVCBasicsAssignment1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                return View(HomeController.AddBook(book));   
            }
            return View();
        }
    }
}
