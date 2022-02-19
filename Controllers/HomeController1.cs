using Microsoft.AspNetCore.Mvc;

namespace NetAtlas.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
