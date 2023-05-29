using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniDepartmentProject.Models;

namespace MiniDepartmentProject.Controllers
{
    public class PersonelController : Controller
    {
        Context _context = new Context();

		[Authorize]
		public IActionResult Index()
        {
            var personel = _context.Personels.Include(p => p.Department).ToList();
            return View(personel);
        }

        [HttpGet]
        public IActionResult CreatePersonel()
        {
            List<SelectListItem> selectListItems = (from x in _context.Departments.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString(),
                                                    }).ToList();
            ViewBag.departments = selectListItems;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePersonel(Personel personel)
        {
            var department = _context.Departments.Find(personel.Department.Id);
            personel.Department = department;
            _context.Add(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
