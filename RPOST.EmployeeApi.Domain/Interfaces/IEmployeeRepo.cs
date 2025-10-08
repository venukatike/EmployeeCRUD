using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Interfaces
{
    public interface IEmployeeRepo
    {
        Task<List<Employee>> GetAll();
        Task<Employee> AddEmployee(Employee employee);
        Task UpdateEmployee();
        Task<Employee> EmployeeById(string Id);

        Task<Employee> DeleteEmployee(Employee employee);
    }
}
