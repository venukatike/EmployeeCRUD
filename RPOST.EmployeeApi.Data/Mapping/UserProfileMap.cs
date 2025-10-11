using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Mapping
{
    public class UserProfileMap : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("UserProfile");
            builder.HasKey(e => e.Email);
            builder.Property(e => e.Email).HasColumnName("EmailAddress");
            builder.Property(e => e.Password).HasColumnName("PasswordHash");
        }
}
}
