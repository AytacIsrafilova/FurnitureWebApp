using Microsoft.AspNetCore.Mvc;

namespace CarWebApp.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
