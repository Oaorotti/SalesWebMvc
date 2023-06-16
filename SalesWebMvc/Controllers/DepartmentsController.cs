using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();

            departments.Add(new Department { Id = 1, Name = "Computers" });
            departments.Add(new Department { Id = 1, Name = "Games" });

            return View(departments);
        }
    }
}
