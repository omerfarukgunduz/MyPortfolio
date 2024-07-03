using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Index()
		{
			ViewBag.value1 = context.Skills.Count();
			ViewBag.value2 = context.Messages.Count();
			ViewBag.value5 = context.Projects.Count();
			ViewBag.value7 = context.Messages.Count();
			ViewBag.value3 = context.Messages.Where(x=> x.IsRead==false).Count();
			ViewBag.value4 = context.Messages.Where(x=> x.IsRead==true).Count();
			return View();
		}
	}
}
