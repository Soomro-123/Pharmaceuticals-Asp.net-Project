using Microsoft.AspNetCore.Mvc;

namespace Pharmaceuticals.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
