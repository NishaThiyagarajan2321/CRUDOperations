using CRUDOperations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Controllers
{
    public class EmployeeController : Controller
    {
         
         Employee emp = new Employee();
        public static List<Employee> employees = Employee.getAllEmployee();
        // GET: EmployeeController
        public ActionResult EmployeeDetails()
        {
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            Employee emp1 = employees.Where(s => s.EmpId == id).FirstOrDefault();
            return View(emp1);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
               
                    emp.Addemployee(employee);
                    return RedirectToAction("EmployeeDetails");
            }
            catch(Exception)
            {
                return View("Error");
            }
            return View();
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp1 = employees.Where(s => s.EmpId == id).FirstOrDefault();

            return View(emp1);
          
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Employee employee)
        {
            try
            {
                Employee emp1 = employees.Where(s => s.EmpId == id).FirstOrDefault();
                emp1.EmpId = employee.EmpId;
                emp1.Empname = employee.Empname;
                emp1.Salary = employee.Salary;
                return RedirectToAction("EmployeeDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp1 = employees.Where(s => s.EmpId == id).FirstOrDefault();
            return View(emp1);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                Employee emp1 = employees.Where(s => s.EmpId == id).FirstOrDefault();
                employees.Remove(emp1);
                return RedirectToAction("EmployeeDetails");
            }
            catch
            {
                return View();
            }
        }
    }
}
