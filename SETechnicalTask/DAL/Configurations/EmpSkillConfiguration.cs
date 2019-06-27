using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    public class EmpSkillConfiguration : IEntityTypeConfiguration<EmployeeSkill>
    {
        public void Configure(EntityTypeBuilder<EmployeeSkill> builder)
        {
            builder.HasKey(
                es=> new {es.SkillId , es.EmpId}
                );

            builder
                .HasOne(a => a.Employee)
                .WithMany(a => a.EmployeeSkills)
                .HasForeignKey(a => a.EmpId);
            builder
                .HasOne(a => a.Skill)
                .WithMany(a => a.SkillEmployees)
                .HasForeignKey(a => a.SkillId);
        }
    }
}
