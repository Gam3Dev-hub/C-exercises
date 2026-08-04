using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;

namespace MVCBasicsAssignment1.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GuessingGame()
        {
            var rand = new Random();
            var randnumber = rand.Next(1, 101);
            var num = HttpContext.Session.GetInt32("NumberToGuess");
            //Making sure the number stays the same even if the user switches views.
            if(num == null)
            {
                Models.GuessingGame.NumberToGuess = randnumber;
            }
           
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetInt32("NumberToGuess", Models.GuessingGame.NumberToGuess);
                
                ViewBag.guessedNumbers = Models.GuessingGame.GuessedNumbers.Count;
                return View();
            }
            return View();
        }


        [HttpPost]
        public IActionResult GuessingGame(GuessingGame game)
        {
            
            var setUserGuess = HttpContext.Session.GetInt32("NumberToGuess");
            if (ModelState.IsValid)
            {
                ViewBag.guessedNumber = HttpContext.Session.GetInt32("UserGuess");
                ViewBag.result = game.CheckGuess(game.UserGuess);
                ViewBag.guessedNumbers = Models.GuessingGame.GuessedNumbers;
                ViewBag.message = HttpContext.Session.GetString("Message");

                return View(game);
            }
            
            return View(game);
        }
    }
}
