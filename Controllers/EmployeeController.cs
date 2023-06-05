using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_Code_First_MVC_Employe_Crud.Models;
using System.Data.Entity;

namespace EF_Code_First_MVC_Employe_Crud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _dbcontext;

        public EmployeeController()
        {
            this._dbcontext = new EmployeeDbContext();
        }
        //Get Employee
        public ActionResult Index()
        {
            var employeelist = this._dbcontext.employees.Include(x => x.department).ToList();
            return View(employeelist);
        }

        public ActionResult AddEmployees()
        {
            var employeeViewModel = new EmployeeViewModel()
            {
                Department = this._dbcontext.departments.ToList(),
                Employee = new Employee()
            };
            return View("EmployeeForm", employeeViewModel);
        }

        public ActionResult Edit(int id)
        {
            var employees = this._dbcontext.employees.FirstOrDefault(x => x.EmployeeId == id);
            var department = this._dbcontext.departments.ToList();

            var viewModel = new EmployeeViewModel()
            {
                Department = department,
                Employee = employees
            };
            return View("EmployeeForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddEmployees", "Employee");
            }

            if (employee.EmployeeId == 0)
                this._dbcontext.employees.Add(employee);

            else
            {
                var employeesDb = this._dbcontext.employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                employeesDb.EmployeeName = employee.EmployeeName;
                employeesDb.EmployeeDesignation = employee.EmployeeDesignation;
                employeesDb.EmployeeAddress = employee.EmployeeAddress;
                employeesDb.EmployeePassport = employee.EmployeePassport;
                employeesDb.Employeephone = employee.Employeephone;
                employeesDb.EmployeeGender = employee.EmployeeGender;
                employeesDb.city = employee.city;
                employeesDb.project = employee.project;
                employeesDb.companyName = employee.companyName;
                employeesDb.Pincode = employee.Pincode;
            }

            this._dbcontext.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Delete(int id)
        {
            var employeeDb = this._dbcontext.employees.FirstOrDefault(x => x.EmployeeId == id);
            this._dbcontext.employees.Remove(employeeDb);
            this._dbcontext.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }
    }
    }
