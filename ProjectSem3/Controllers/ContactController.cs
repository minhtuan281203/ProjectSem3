using Microsoft.AspNetCore.Mvc;

namespace ProjectSem3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
