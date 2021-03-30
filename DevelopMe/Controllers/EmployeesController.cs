using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopMe.Data;
using DevelopMe.DTOs;
using DevelopMe.Models;
using DevelopMe.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DevelopMe.Controllers
{
    public class EmployeesController : Controller
    {
        public ApplicationDbContext dbContext;
        
        public EmployeesController()
        {
            this.dbContext = EF_Model.dbContext;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EmployeeViewModel
                {
                    Employee = employee
                };
                return View("NewEmployee", viewModel);
            }

            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult NewEmployee()
        {
            return View();
        }

    }
}