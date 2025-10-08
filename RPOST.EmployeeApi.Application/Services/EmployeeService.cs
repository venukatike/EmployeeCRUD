using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Application.Interfaces;
using RPOST.EmployeeApi.Data.Interfaces;
using RPOST.EmployeeApi.Domain.DTOs;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<List<EmployeeDTO>> GetAll()
        {
            var employee = await _employeeRepo.GetAll();

            var employeeDto = employee.Select(x => new EmployeeDTO
            {
                EmployeeId= x.EmployeeId,
                FirstName= x.FirstName,
                LastName = x.LastName,
                JobTitle = x.JobTitleNavigation?.JobTitles
               
            }).ToList();
            return employeeDto;
        }

        public async Task<EmployeeDTO> AddEmployee(EmployeeDTO employee)
        {
            var emp = new Employee
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                JobTitle = employee.JobTitle,
                EmailAddress = "Venu@Gmail.com",
                CreatedDate = DateOnly.MinValue,
                ModifiedDate = DateOnly.MaxValue,
                CreatedUser = "narender",
                ModifiedUser = "venu",


            };

              await _employeeRepo.AddEmployee(emp);

            return employee;
        }

        public async Task<EmployeeDTO> UpdateEmployee(string id, EmployeeDTO employee)
        {
            var emp = await _employeeRepo.EmployeeById(id);

            emp.EmployeeId = id;
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.JobTitle = employee.JobTitle;
           
                await _employeeRepo.UpdateEmployee();

            return employee;
        }

        public async Task<Employee> DeleteEmployee(string id)
        {
            var emp = await _employeeRepo.EmployeeById(id);

            return await _employeeRepo.DeleteEmployee(emp);
            
        }
        

    }
}
