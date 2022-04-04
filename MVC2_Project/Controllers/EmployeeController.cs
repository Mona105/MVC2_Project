using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC2_Project.Models;

namespace MVC2_Project.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Job> jobs = dbContext.Jobs.ToList();
            return View(jobs);
        }
        public IActionResult EmployeeList(int id)
        {
            List<Employee> employees = dbContext.Employees.Where(e => e.Job.Id == id).ToList();
            return View(employees);
        }
    }
}
