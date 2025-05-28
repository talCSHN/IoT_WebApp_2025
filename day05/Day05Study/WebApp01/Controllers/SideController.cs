using Microsoft.AspNetCore.Mvc;

namespace WebApp01.Controllers
{
    public class SideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
    }
}
