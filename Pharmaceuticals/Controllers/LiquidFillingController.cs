using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmaceuticals.DbContextClass;

namespace Pharmaceuticals.Controllers
{
    public class LiquidFillingController : Controller
    {
        private readonly PharmaDbContextClass _context;
        public LiquidFillingController(PharmaDbContextClass context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.LiquidFillings.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            else
            {
                var filling = await _context.LiquidFillings.FindAsync(id);
                if (id == null)
                {
                    return NotFound();

                }
                return View(filling);
            }
        }
    }
}
