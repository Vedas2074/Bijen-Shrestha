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
            var employee = db.Employees.ToList();
            return View(employee);
        }

        public ActionResult Detail(int Id)
        {
            var abc = db.Employees.Find(Id);
            return View(abc);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var abcd = db.Employees.Find(Id);
            return View(abcd);
        }


        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var abcde = db.Employees.Find(Id);
            return View(abcde);
        }


        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}