using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    [Authorize]

    public class ProjectController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult ProjectList()
		{
			var values = context.Projects.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateProject()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateProject(Project project)
		{
			context.Projects.Add(project);
			context.SaveChanges();
			return RedirectToAction("ProjectList");

		}

		public IActionResult DeleteProject(int id)
		{
			var value = context.Projects.Find(id);
			context.Projects.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ProjectList");

		}

		[HttpGet]
		public IActionResult UpdateProject(int id)
		{
			var value = context.Projects.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateProject(Project project)
		{
			context.Projects.Update(project);
			context.SaveChanges();
			return RedirectToAction("ProjectList");
		}


	}
}
