using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;
using MVCBasicsAssignment1.Models;

namespace MVCBasicsAssignment1.Controllers
{
    public class HobbiesController : Controller
    {
        public IActionResult Hobbies()
        {
            ViewData["Title"] = "Hobbies";
            ViewData["Description"] = "Hobbies viewdata";
            ViewBag.Message = "Hobbies viewbag";
            //An object of the hobbies class in the Models folder.
            ViewBag.Hobbies = new Hobbies()
            {
                Othello = "Othello",
                VideoGames = "Video Games",
                BoardGames = "Board Games",
                Reading = "Reading",
                Cooking = "Cooking"
            };


            return View();
        }

        public IActionResult Hobbies2()
        {
            
            return View();
        }
    }
}
