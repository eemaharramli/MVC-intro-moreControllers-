using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View(nameof(Index));
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}