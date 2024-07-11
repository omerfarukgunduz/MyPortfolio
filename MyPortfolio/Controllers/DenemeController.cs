using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
