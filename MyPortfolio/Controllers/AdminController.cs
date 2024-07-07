using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values= context.Admins.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values= context.Admins.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Admin admin)
        {
			context.Admins.Update(admin);
			context.SaveChanges();
			return RedirectToAction("Index");
        }
    }
}
