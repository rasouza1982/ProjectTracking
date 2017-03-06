
using System;
using System.Collections.Generic;

namespace ProjectTrackingServices.Entities
{
    public class Employee
    {
        public Employee()
        {
            this.ProjectTasks = new HashSet<ProjectTask>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int? ManagerId { get; set; }
        public string ContactNo { get; set; }
        public string EMailId { get; set; }
        public string SkillSets { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}