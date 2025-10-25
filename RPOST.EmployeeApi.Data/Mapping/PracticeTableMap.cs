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
    public class PracticeTableMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PracticeTable");

            builder.HasKey(e => e.ProductId).HasName("ProductId");

        }
    }
}
