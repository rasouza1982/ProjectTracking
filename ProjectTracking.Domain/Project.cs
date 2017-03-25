using System;
using System.Collections.Generic;

namespace ProjectTrackingServices.Entities
{
    public class Project
    {
        public Project()
        {
            UserStories = new HashSet<UserStory>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ClientName { get; set; }

        public virtual ICollection<UserStory> UserStories { get; set; }
    }
}