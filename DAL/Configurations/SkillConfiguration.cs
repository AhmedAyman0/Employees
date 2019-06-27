using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configurations
{
    class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skills");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ForSqlServerUseSequenceHiLo("SkillSeq");
            builder.Property(a => a.Name).IsRequired(true);
        //    builder
        //        .HasOne(a => a.Employee)
        //        .WithMany(a => a.Skills)
        //        .HasForeignKey(a => a.EmployeeId);
        }
    }
}
