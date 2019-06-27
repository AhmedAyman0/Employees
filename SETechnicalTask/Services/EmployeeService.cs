using DAL;
using Microsoft.EntityFrameworkCore;
using SETechnicalTask.Models;
using SETechnicalTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EmployeeService
    {
        private readonly EmpContext _db;
        private readonly SkillService skillService;
        public EmployeeService(EmpContext db, SkillService service)
        {
            _db = db;
            skillService = service;
        }
        public void AddEmployee(Employee Emp,string[] skills)
        {

            _db.Add(Emp);
            _db.SaveChanges();
            //var emps = _db.Employees.Include(a => a.EmployeeSkills);
            var emp = emps.FirstOrDefault(a => a.Id == Emp.Id);
            if (skills[0].Contains(','))
            {
                var s = skills[0].Split(',');
                foreach (var item in s)
                {
                    var skill = skillService.Get(item);
                    _db.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                   // emp.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                }
            }
            else
            {
                var skill = skillService.Get(skills[0]);
                _db.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                //Emp.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
            }
            _db.Update(emp);
            _db.SaveChanges();
        }
        public void EditEmployee(Employee Emp,string[] skills)
        {
            _db.EmployeeSkills.RemoveRange(Emp.EmployeeSkills);
            if (skills[0].Contains(','))
            {

                var s = skills[0].Split(',');
                foreach (var item in s)
                {
                    var skill = skillService.Get(item);
                    _db.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                    // emp.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                }
            }
            else
            {
                var skill = skillService.Get(skills[0]);
                _db.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
                //Emp.EmployeeSkills.Add(new EmployeeSkill { EmpId = Emp.Id, SkillId = skill.Id });
            }
            _db.Employees.Update(Emp);
            _db.SaveChanges();

        }
        public void DeleteEmployee(int id)
        {
            var emp = _db.Employees.Find(id);

            _db.Employees.Remove(emp);
            _db.SaveChanges();
        }
        public IEnumerable<Employee> GetAll()
        {
            return _db.Employees.ToList();
        }
        public Employee Get(int id)
        {
            
            return _db.Employees.Find(id);
        }
    }
}
