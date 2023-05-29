using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniDepartmentProject.Models;

namespace MiniDepartmentProject.Controllers
{
    public class PersonelController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var personel = _context.Personels.Include(p => p.Department).ToList();
            return View(personel);
        }
    }
}
