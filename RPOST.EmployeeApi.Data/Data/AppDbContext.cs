using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<JuncEmployeeProjects> JuncEmployeeProjects { get; set; }
        public DbSet<Product> PracticeTables { get; set; }
        //public DbSet<> 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(entity =>
            //{
            //    entity.ToTable("Employee");
            //    entity.HasKey(e => e.EmployeeId);

            //    entity.HasOne(d => d.JobTitleNavigation).WithMany(p => p.Employees)
            //        .HasForeignKey(d => d.JobTitle);
            //});
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            //modelBuilder.Entity<JobTitle>(entity =>
            //{
            //    entity.ToTable("JobTitle");
            //    entity.HasKey(e => e.JobTitles);
            //    entity.Property(e => e.JobTitles).HasColumnName("JobTitle");
            //});
        }
    }
}
