using Microsoft.AspNetCore.Mvc;
using POE_Part_1.Models;
using System.Diagnostics;

namespace POE_Part_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int userID)
        {
            ViewData["userID"] = userID;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.ActivePage = "Privacy";
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Home";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.ActivePage = "AboutUs";
            return View();
        }

        public ActionResult OurWork()
        {
            ViewBag.ActivePage = "OurWork";
            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.ActivePage = "ContactUs";
            return View();
        }
    }
}