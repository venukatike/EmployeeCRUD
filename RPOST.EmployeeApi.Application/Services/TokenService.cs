using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RPOST.EmployeeApi.Application.Interfaces;

namespace RPOST.EmployeeApi.Application.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly string _key;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _expiresMinutes;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
            _key = _configuration["Jwt:Key"] ?? throw new ArgumentNullException("Jwt:Key");
            _issuer = _configuration["Jwt:Issuer"] ?? "MyAuthServer";
            _audience = _configuration["Jwt:Audience"] ?? "MyApiClients";
            _expiresMinutes = int.TryParse(_configuration["Jwt:ExpiresMinutes"], out var m) ? m : 60;
        }
        public string CreateToken(string userId, string userName, IEnumerable<Claim>? additionalClaims = null)
        {
            var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, userName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("uid", userId)
        };

            if (additionalClaims != null)
                claims.AddRange(additionalClaims);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(_expiresMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
