using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Empl");
            builder.HasKey(e => e.EmployeeId);
            builder.HasOne(d => d.JobTitleNavigation).WithMany(p => p.Employees).HasForeignKey(d => d.JobTitle);
            builder.HasMany(e => e.juncEmployeeProjects).WithOne(w => w.employees);
            
        }
    }
}
