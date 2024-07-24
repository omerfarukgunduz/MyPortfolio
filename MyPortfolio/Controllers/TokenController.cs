using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class TokenController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.Tokens.ToList();
            return View(values);
        }


		[HttpGet]
		public IActionResult TokenUpdate(int id)
		{
			var values = context.Tokens.Find(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult TokenUpdate(Token token )
		{
			context.Tokens.Update(token);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
