using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPOST.EmployeeApi.Application.Interfaces;
using RPOST.EmployeeApi.Data.Data;
using RPOST.EmployeeApi.Domain.Entities;

namespace EmployeeCRUD.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class AuthController : Controller
    {
        private readonly ITokenService _tokenService;
        private readonly AppDbContext _db;
        // Replace with your user validation (DB/Identity)
        public AuthController(ITokenService tokenService, AppDbContext context)
        {
            _tokenService = tokenService;
            _db = context;
        }

        // POST api/auth/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserProfile request)
        {
            var user =  _db.UserProfiles
             .FirstOrDefault(u => u.Email == request.Email && u.Password == request.Password);

            // TODO: validate username/password against DB or Identity server
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Invalid credentials");

            // Example: accept "admin"/"password" for demo only
            if (user==null)
                return Unauthorized();

            // On success create token
            var token = _tokenService.CreateToken(userId: "1", userName: request.Email
                );

            return Ok(new { token });
        }

        public record LoginRequest(string Username, string Password);
    }
}
