using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RPOST.EmployeeApi.Domain.Entities;

namespace RPOST.EmployeeApi.Data.Mapping
{
    public class Projects
    {
        public string ProjectWBSId { get; set; } = null!;
        public string ?ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }

        [JsonIgnore]
        public ICollection<JuncEmployeeProjects> juncEmployeeProjects { get; set; } = new List<JuncEmployeeProjects>();
    }
}
