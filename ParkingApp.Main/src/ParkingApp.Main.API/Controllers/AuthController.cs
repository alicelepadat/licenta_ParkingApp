using Microsoft.AspNetCore.Mvc;

namespace ParkingApp.Main.API.Controllers
{
    public class AuthController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}