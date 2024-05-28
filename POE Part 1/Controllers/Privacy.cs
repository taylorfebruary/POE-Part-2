using Microsoft.AspNetCore.Mvc;

namespace POE_Part_1.Controllers
{
    public class Privacy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
