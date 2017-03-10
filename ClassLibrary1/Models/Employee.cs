using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.ProjectTasks = new List<ProjectTask>();
        }

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string ContactNo { get; set; }
        public string EMailID { get; set; }
        public string SkillSets { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
