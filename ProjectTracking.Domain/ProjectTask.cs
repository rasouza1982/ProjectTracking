

using System;
using System.Collections.Generic;

namespace ProjectTrackingServices.Entities
{
    public class ProjectTask
    {
        public ProjectTask()
        {
            ManagerComments = new HashSet<ManagerComment>();
        }

        public int ProjectTaskID { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public int? TaskCompletion { get; set; }
        public int? UserStoryID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<ManagerComment> ManagerComments { get; set; }
        public virtual UserStory UserStory { get; set; }
    }
}