using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ForSqlServerUseSequenceHiLo("EmpSeq");
            builder.Property(a => a.Name).IsRequired(true);
            builder.Property(a => a.Email).IsRequired(true);
        }
    }
}
