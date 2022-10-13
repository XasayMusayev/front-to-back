using Microsoft.AspNetCore.Mvc;

namespace Front_to_back_homework.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
