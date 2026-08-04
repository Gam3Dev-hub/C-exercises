using Microsoft.AspNetCore.Mvc;
using MVCBasicAssignment2.Data;
using MVCBasicAssignment2.Models;
using System.Diagnostics;

namespace MVCBasicAssignment2.Controllers
{
    public class HomeController : Controller
    {

        //private readonly AppDBContext _dbContext;

        //public HomeController(AppDBContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public IActionResult Index()
        {
            //var products = _dbContext.Products.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
