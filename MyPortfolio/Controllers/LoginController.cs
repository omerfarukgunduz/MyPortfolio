using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using System.Security.Claims;

namespace MyPortfolio.Controllers
{

    public class LoginController : Controller
    {
		MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
		public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Index(Admin value)
        {
            var input=context.Admins.FirstOrDefault(x=> x.Username==value.Username && x.Password==value.Password);
            if(input != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,value.Username)

                };
                var useridentity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties=new AuthenticationProperties();
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(useridentity),authProperties);
                return RedirectToAction("AboutList","About");
            }
            return View();
        }
           
        [HttpGet]        
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
            


	}
}
