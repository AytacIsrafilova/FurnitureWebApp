using CarWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApp.Controllers
{
    public class OurDesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture1 = new Furniture()
            {
                Id = 1,
                Name = "Metbex mebeli"
            };
            Furniture furniture2 = new Furniture()
            {
                Id = 2,
                Name = "Qonaq otagi mebeli"
            };
            Furniture furniture3 = new Furniture()
            {
                Id = 3,
                Name = "Usaq otagi mebeli"
            };
            List<Furniture> furnitures = new List<Furniture>();
            furnitures.Add(furniture1);
            furnitures.Add(furniture2);
            furnitures.Add(furniture3);

            ViewBag.Data= furnitures;


            return View();
        }
        


       
        

    }
}
