using Microsoft.AspNetCore.Mvc;

namespace MiniDepartmentProject.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
