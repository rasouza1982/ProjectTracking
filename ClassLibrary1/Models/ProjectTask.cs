using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class ProjectTask
    {
        public ProjectTask()
        {
            this.ManagerComments = new List<ManagerComment>();
        }

        public int ProjectTaskID { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<System.DateTime> TaskStartDate { get; set; }
        public Nullable<System.DateTime> TaskEndDate { get; set; }
        public Nullable<int> TaskCompletion { get; set; }
        public Nullable<int> UserStoryID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ManagerComment> ManagerComments { get; set; }
        public virtual UserStory UserStory { get; set; }
    }
}
