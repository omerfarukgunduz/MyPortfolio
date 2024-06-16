using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class ProjectComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
