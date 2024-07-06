using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    [Authorize]

    public class CVUrlController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Index()
		{
			var values = context.DownloadCVs.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult UpdateCVUrl(int id)
		{
			var value = context.DownloadCVs.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateCVUrl(DownloadCV downloadCV)
		{
			context.DownloadCVs.Update(downloadCV);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
