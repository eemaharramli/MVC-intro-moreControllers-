using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home Index");
        }

        public IActionResult Create()
        {
            return Content("Home Create");
        }

        public IActionResult Detail(int? id)
        {
            return Content($"Student number {id}");
        }

        public ViewResult Update()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "Update";

            return viewResult;
        }

        public ViewResult Delete()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "Delete";

            return viewResult;
        }
    }
}