using Microsoft.AspNetCore.Mvc;

namespace stateManagement.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            TempData["userId"] = 106;
            return View();
        }

        public IActionResult Get1()
        {
            var userId = TempData["userId"] ?? null;
            return View();
        }

        public IActionResult Get2()
        {
            var userId = TempData["userId"] ?? null;
            return View();
        }

        

    }
}
