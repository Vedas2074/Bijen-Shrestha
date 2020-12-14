using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using System.Collections.Generic;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {   
            var departments = Department.GetDepartment();
            return View(departments);
        }

        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public string Add(Department department)
        {
            return "Record Created";
        }
    }
}