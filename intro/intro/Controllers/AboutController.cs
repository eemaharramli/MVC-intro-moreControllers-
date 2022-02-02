using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "Home About";
        }

        public IActionResult Create()
        {
            return RedirectToAction(nameof(Index), "Products");
        }

        public IActionResult WrongInput() {
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}