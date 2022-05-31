using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.Manage.Controllers
{
    public class HomeController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
