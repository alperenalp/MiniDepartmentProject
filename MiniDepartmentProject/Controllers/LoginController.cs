using Microsoft.AspNetCore.Mvc;

namespace MiniDepartmentProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
