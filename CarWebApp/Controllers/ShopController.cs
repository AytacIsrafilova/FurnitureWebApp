using Microsoft.AspNetCore.Mvc;

namespace CarWebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
