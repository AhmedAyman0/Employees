using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Services;
using SETechnicalTask.Models;

namespace SETechnicalTask.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService empService;
        private readonly Services.SkillService sService;
        public EmployeeController(EmployeeService   employeeService,Services.SkillService skillService  )
        {
            empService = employeeService;
            sService = skillService;
        }
        public IActionResult Index()
        {
            var emps=empService.GetAll();
            return View(emps);
        }
        [HttpPost]
        public IActionResult Add(Employee Emp,string[] skills)
        {
            if (ModelState.IsValid)
            {
                empService.AddEmployee(Emp,skills);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(Emp);
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            empService.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Edit(int id)
        {
            var emp = empService.Get(id);
            if (emp == null)
                return NotFound();
            else
                return View(emp);
        }
        public IActionResult Edit(Employee emp)
        {
            empService.EditEmployee(emp);
            return RedirectToAction(nameof(Index));
        }
    }
}