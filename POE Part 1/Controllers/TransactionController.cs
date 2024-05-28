using Microsoft.AspNetCore.Mvc;

namespace POE_Part_1.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Create(TransactionController order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        public IActionResult ClientOrders(int clientId)
        {
            var orders = _context.Orders
                .Where(o => o.ClientID == clientId)
                .Include(o => o.Product)
                .ToList();
            return View(orders);
        }

        public IActionResult AllOrders()
        {
            var orders = _context.Orders
                .Include(o => o.Client)
                .Include(o => o.Product)
                .ToList();
            return View(orders);
        }
    }
}