using Microsoft.AspNetCore.Mvc;

namespace POE_Part_1.Controllers
{
    public class OurWork
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Price { get; set; }
        public string ImageUrl { get; set; }
    }
    public class OurWorkController : Controller
    {
        public IActionResult MyWork()
        {
            var craftworks = new List<OurWork>
        {
            new OurWork { Id = 1, Name = "Handmade Vase", Price = "R750", ImageUrl = "/images/product1.jpg" },
            new OurWork { Id = 2, Name = "Woven Basket", Price = "R500", ImageUrl = "/images/product2.jpg" },
            new OurWork { Id = 3, Name = "Candle Covers", Price = "R300", ImageUrl = "/images/product3.jpg" },
            new OurWork { Id = 4, Name = "Baskets", Price = "R250", ImageUrl = "/images/product4.jpg" }
        };

            return View(craftworks);
        }
    }
}
