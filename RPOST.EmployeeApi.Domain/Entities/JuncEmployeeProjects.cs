using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Data.Mapping;

namespace RPOST.EmployeeApi.Domain.Entities
{
    public class JuncEmployeeProjects
    {
        public string EmployeeId { get; set; }
        public string ProjectWBSId { get; set; }

        public Employee employees { get; set; } 
        public Projects projects { get; set; }
    }
}
