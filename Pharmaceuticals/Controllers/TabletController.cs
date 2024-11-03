using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmaceuticals.DbContextClass;

namespace Pharmaceuticals.Controllers
{
    public class TabletController : Controller
    {
        private readonly PharmaDbContextClass _context;
        public TabletController(PharmaDbContextClass context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tablets.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            else
            {
                var tablets = await _context.Tablets.FindAsync(id);
                if (id == null)
                {
                    return NotFound();

                }
                return View(tablets);
            }
        }
    }
}
