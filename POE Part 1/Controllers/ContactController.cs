using Microsoft.AspNetCore.Mvc;
using POE_Part_1.Models;
using System;

namespace POE_Part_1.Controllers
{
    public class ContactController : Controller
    {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Index(ContactForm model)
            {
                if (ModelState.IsValid)
                {
                    // Here you would typically send the data to an email or store it in a database
                    ViewBag.Message = "Thank you for contacting us. We will get back to you shortly.";
                    return View("Thanks");
                }

                return View(model);
            }
        }
    }
