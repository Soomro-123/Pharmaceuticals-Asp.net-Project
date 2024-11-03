using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmaceuticals.DbContextClass;

namespace Pharmaceuticals.Controllers
{
    public class CapsulesController : Controller
    {
        private readonly PharmaDbContextClass _context;
        public CapsulesController(PharmaDbContextClass context)
        {
            _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.tbl_Capsules.ToListAsync());
        }
        public  async Task<IActionResult> Details(int? id) {
            if (id == null)
            {
                return NotFound();

            }
            else
            {
                var capsule = await _context.tbl_Capsules.FindAsync(id);
                if (id == null)
                {
                    return NotFound();

                }
                ViewBag.Capsules = capsule;
               
                return View(capsule);
            }
        }
    }
}
