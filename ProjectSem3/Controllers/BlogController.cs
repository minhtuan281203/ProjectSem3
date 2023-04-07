using Microsoft.AspNetCore.Mvc;

namespace ProjectSem3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
