using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            ViewData["Title"] = "Hello";
            return View();
        }

        public IActionResult About2()
        {
            ViewData["Title"] = "Hello Again";
            return View();
        }
    }
}
