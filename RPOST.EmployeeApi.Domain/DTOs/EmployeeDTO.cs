using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOST.EmployeeApi.Domain.DTOs
{
    public class EmployeeDTO
    {
        public string EmployeeId { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? JobTitle { get; set; }
    }
}
