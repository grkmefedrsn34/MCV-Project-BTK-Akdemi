using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class EmployeeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Apply()
        {
            return View();
        }
    }
}