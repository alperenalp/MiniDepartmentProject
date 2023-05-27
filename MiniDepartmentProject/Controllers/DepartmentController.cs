using Microsoft.AspNetCore.Mvc;
using MiniDepartmentProject.Models;

namespace MiniDepartmentProject.Controllers
{
    public class DepartmentController : Controller
    {
        private Context _context = new Context();

        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

        [HttpGet]
        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult GetDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            return View(department);
        }
    }
}
