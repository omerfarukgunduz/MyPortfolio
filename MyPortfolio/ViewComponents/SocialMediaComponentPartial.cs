using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class SocialMediaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
