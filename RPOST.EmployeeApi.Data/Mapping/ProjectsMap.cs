using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPOST.EmployeeApi.Data.Mapping
{
    public class ProjectsMap : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(e=>e.ProjectWBSId).HasName("ProjectWBSId");
            builder.HasMany(e => e.juncEmployeeProjects).WithOne(e => e.projects);
            
        }
    }
}
