using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPOST.EmployeeApi.Application.Interfaces;
using RPOST.EmployeeApi.Domain.DTOs;
using RPOST.EmployeeApi.Domain.Entities;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        [HttpGet("get")]
        public async Task<List<EmployeeDTO>> GetAll()
        {
            return await employeeService.GetAll();
        }

        [HttpPost("Post")]
        public async Task<IActionResult> AddEmployee(EmployeeDTO employeeDto)
        {
           await employeeService.AddEmployee(employeeDto);

            return Ok("Saved !");
        }

        [HttpPut("Update/{Id}")]
        public async Task<IActionResult> AddEmployee(string Id,EmployeeDTO employeeDto)
        {
            await employeeService.UpdateEmployee(Id,employeeDto);

            return Ok("Updated !");
        }

        [HttpDelete("Delete/{Id}")]
        public async Task<IActionResult> DeleteEmployee(string Id)
        {
            await employeeService.DeleteEmployee(Id);

            return Ok("Updated !");
        }
    }
}
