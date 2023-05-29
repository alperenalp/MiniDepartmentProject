using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MiniDepartmentProject.Models;
using System.Security.Claims;

namespace MiniDepartmentProject.Controllers
{
    public class LoginController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User request)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Username == request.Username && x.Password == request.Password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, request.Username)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Personel");
            }
            return View();
        }
    }
}
