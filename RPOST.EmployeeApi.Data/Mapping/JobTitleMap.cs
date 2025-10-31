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
    public class JobTitleMap : IEntityTypeConfiguration<JobTitle>
    {
        public void Configure(EntityTypeBuilder<JobTitle> builder)
        {
            builder.ToTable("JobTitle");
            builder.HasKey(e => e.JobTitlesz);
            builder.Property(e => e.JobTitlesz).HasColumnName("JobTitle");
            builder.Property(e => e.JobDescription).HasColumnName("JobDescription");
        }
    }
}
