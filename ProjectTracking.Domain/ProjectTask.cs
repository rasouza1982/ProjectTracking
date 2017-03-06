

using System;
using System.Collections.Generic;

namespace ProjectTrackingServices.Entities
{
    public class ProjectTask
    {
        public ProjectTask()
        {
            this.ManagerComments = new HashSet<ManagerComment>();
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