using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class EducationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
