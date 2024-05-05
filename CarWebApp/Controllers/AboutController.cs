using Microsoft.AspNetCore.Mvc;

namespace CarWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
