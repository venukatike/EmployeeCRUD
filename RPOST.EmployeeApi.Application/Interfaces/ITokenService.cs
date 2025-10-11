using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RPOST.EmployeeApi.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(string userId, string userName, IEnumerable<Claim>? additionalClaims = null);

    }
}
