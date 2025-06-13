using Microsoft.AspNetCore.Mvc;

namespace WebFrontEndApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
