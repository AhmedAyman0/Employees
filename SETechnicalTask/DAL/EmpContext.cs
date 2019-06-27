using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions opts):base(opts)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new EmpSkillConfiguration());
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "PHP" },
                new Skill { Id = 2, Name = "ASP.NET" },
                new Skill { Id = 3, Name = "iOS" },
                new Skill { Id = 4, Name = "Android" }
                );

        }

        public DbSet<Employee> Employees;
        public DbSet<Skill> Skills;

    }
}
