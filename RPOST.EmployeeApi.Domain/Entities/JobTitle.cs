using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOST.EmployeeApi.Domain.Entities
{
    public class JobTitle
    {
        public string JobTitles { get; set; } = null!;

        public string? JobDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();



    }
}
