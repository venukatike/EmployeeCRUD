using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPOST.EmployeeApi.Data.Data;
using RPOST.EmployeeApi.Domain.Entities;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppDbContext ctx;
        public ValuesController(AppDbContext atx)
        {
            ctx = atx;
        }

        [HttpGet]
        public async Task<List<Employee>> get()
        {
            return await ctx.Employee
                .Include(e => e.juncEmployeeProjects)
                    .ThenInclude(j => j.projects) // Corrected navigation to projects
                .ToListAsync();
        }
    }
}
