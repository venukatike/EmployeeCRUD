using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Domain.DTOs;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetAll();
        Task<EmployeeDTO> AddEmployee(EmployeeDTO employee);

        Task<EmployeeDTO> UpdateEmployee(string id, EmployeeDTO employee);

        Task<Employee> DeleteEmployee(string id);
    }
}
