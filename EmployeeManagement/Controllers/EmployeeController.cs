using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using EmployeeManagement.Models;
using EmployeeManagement.Data;

namespace EmployeeManagement.Controllers{
    public class EmployeeController: Controller{
        private readonly EMContext db;
        public EmployeeController(EMContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {   
            var employees = db.Employees.ToList();
            return View(employees);
        }
        public ActionResult Detail(int Id)
        {
            var employees = Employee.GetEmployee();
            var employee=employees.FirstOrDefault(x=>x.Id==Id);
            return View(employee);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(Employee employee)
        {

            return "record";
        }
        
    }
}