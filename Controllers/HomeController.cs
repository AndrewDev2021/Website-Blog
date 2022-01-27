using Microsoft.AspNetCore.Mvc;

namespace FirstWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
