using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
