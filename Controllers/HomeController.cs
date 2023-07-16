using Microsoft.AspNetCore.Mvc;


namespace SpeedCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateSpeed(double speed)
        {
            // Convert m/s to km/h
            double speedKmPerHour = speed * 3.6;

            // Store the result in ViewBag
            ViewBag.SpeedKmPerHour = speedKmPerHour;

            return View("Index");
        }
    }
}
