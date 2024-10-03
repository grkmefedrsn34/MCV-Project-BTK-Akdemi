using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View("../Views/Course/Index.cshtml");
        }

         public IActionResult Apply()
        {
            return View("../Views/Course/Apply.cshtml");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Apply([FromFrom] Candidate model)
        {
            return View("../Views/Course/Apply.cshtml");
        }
    }
}
