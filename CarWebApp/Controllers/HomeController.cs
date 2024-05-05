using Microsoft.AspNetCore.Mvc;

namespace CarWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
