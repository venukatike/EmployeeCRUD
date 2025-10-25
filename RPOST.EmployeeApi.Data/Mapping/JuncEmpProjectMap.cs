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
    public class JuncEmpProjectMap : IEntityTypeConfiguration<JuncEmployeeProjects>
    {
        public void Configure(EntityTypeBuilder<JuncEmployeeProjects> builder)
        {
            /* builder.ToTable("JuncEmployeeProjects");
             builder.HasKey(e => e.EmployeeId).HasName("EmployeeId");
             builder.HasKey(e => e.ProjectWBSId).HasName("ProjectWBSId");

             builder.HasOne(w => w.employees).WithMany(r => r.juncEmployeeProjects).HasForeignKey(h=>h.EmployeeId);
             builder.HasOne(x => x.projects).WithMany(z => z.juncEmployeeProjects)
                 .HasForeignKey(k=>k.ProjectWBSId);
            */


            // modelBuilder.Entity<JuncEmployeeProjects>()
            builder.HasKey(j => new { j.EmployeeId, j.ProjectWBSId }); // composite key

           // modelBuilder.Entity<JuncEmployeeProjects>()
                builder.HasOne(j => j.employees)
                .WithMany(e => e.juncEmployeeProjects)
                .HasForeignKey(j => j.EmployeeId);

            // modelBuilder.Entity<JuncEmployeeProjects>()
            builder.HasOne(j => j.projects)
                .WithMany(p => p.juncEmployeeProjects)
                .HasForeignKey(j => j.ProjectWBSId);
        }
    }
}
