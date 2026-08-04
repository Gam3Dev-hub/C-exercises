using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;

namespace MVCBasicsAssignment1.Controllers
{
    public class FeverController : Controller
    {
        public IActionResult Fever()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fever(Temperature temperature)
        {
            if(ModelState.IsValid)
            {

                ViewBag.Message = Temperature.CheckFever(temperature.Celsius);
                ViewBag.fahrenheit = temperature.fahrenheit;
                ViewBag.kelvin = temperature.Kelvin;
                // You can pass the temperature object to the view if needed
                return View();
                //return RedirectToAction("Fever");
            }
            return View(temperature);
        }

        //[HttpPost]
        //public IActionResult Temperature(Temperature temperature)
        //{
        //    // Process the temperature data
        //    return View();
        //}
    }
}
