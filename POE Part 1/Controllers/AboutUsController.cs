using Microsoft.AspNetCore.Mvc;

namespace POE_Part_1.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
