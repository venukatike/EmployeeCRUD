using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPOST.EmployeeApi.Data.Data;
using RPOST.EmployeeApi.Data.Interfaces;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Repositories
{
  
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext _context;
        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAll()
        {
            var d = await _context.Employee.Include(x=>x.JobTitleNavigation).ToListAsync();

            return d;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _context.Employee.AddAsync(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public async Task UpdateEmployee()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> EmployeeById(string Id)
        {
            return await _context.Employee.Where(x => x.EmployeeId == Id).FirstOrDefaultAsync();
        }

        public async Task<Employee> DeleteEmployee(Employee employee)
        {
              _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }
    }
}
