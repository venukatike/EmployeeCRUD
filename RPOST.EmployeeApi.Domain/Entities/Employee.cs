using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Data.Mapping;

namespace RPOST.EmployeeApi.Domain.Entities
{
    public class Employee
    {
        public string EmployeeId { get; set; } //= null!;   // represents the columnns in a table

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? EmailAddress { get; set; }

        public string? JobTitle { get; set; }

        public DateOnly? CreatedDate { get; set; }

        public DateOnly? ModifiedDate { get; set; }

        public string? CreatedUser { get; set; }

        public string? ModifiedUser { get; set; }

        public JobTitle? JobTitleNavigation { get; set; }
        public ICollection<JuncEmployeeProjects> juncEmployeeProjects { get; set; } = new List<JuncEmployeeProjects>();

    }
}
