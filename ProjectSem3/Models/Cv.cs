using Microsoft.AspNetCore.Mvc;

namespace ProjectSem3.Models
{
    public class Cv : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
