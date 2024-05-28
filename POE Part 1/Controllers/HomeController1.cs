using Microsoft.AspNetCore.Mvc;

namespace POE_Part_1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
