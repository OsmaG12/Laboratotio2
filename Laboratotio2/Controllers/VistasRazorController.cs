using Microsoft.AspNetCore.Mvc;

namespace Laboratotio2.Controllers
{
    public class VistasRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
