using Microsoft.AspNetCore.Mvc;

namespace Front_to_back_homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
