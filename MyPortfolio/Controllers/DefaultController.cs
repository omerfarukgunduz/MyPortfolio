using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class DefaultController : Controller
	{
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult Message()
		{ 
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult Message(Message message)
        {
			context.Messages.Add(message);
			context.SaveChanges();
			return PartialView("Index");
        }


    }
}
