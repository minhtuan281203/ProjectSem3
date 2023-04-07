using Microsoft.AspNetCore.Mvc;

namespace ProjectSem3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
