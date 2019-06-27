using DAL;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class EmployeeService
    {
        private readonly EmpContext _db;

        public EmployeeService(EmpContext db)
        {
            _db = db;
        }
        public void AddEmployee(Employee Emp)
        {
            _db.Add(Emp);
            _db.SaveChanges();

        }
        public void EditEmployee(Employee Emp)
        {
            _db.Employees.Update(Emp);
            _db.SaveChanges();

        }
        public void DeleteEmployee(Employee Emp)
        {
            _db.Employees.Remove(Emp);
            _db.SaveChanges();
        }
    }
}
