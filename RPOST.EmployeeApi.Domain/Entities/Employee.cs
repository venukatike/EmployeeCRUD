using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOST.EmployeeApi.Domain.Entities
{
    public class Employee
    {
        public string EmployeeId { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? EmailAddress { get; set; }

        public string? JobTitle { get; set; }

        public DateOnly? CreatedDate { get; set; }

        public DateOnly? ModifiedDate { get; set; }

        public string? CreatedUser { get; set; }

        public string? ModifiedUser { get; set; }

        public virtual JobTitle? JobTitleNavigation { get; set; }


    }
}
