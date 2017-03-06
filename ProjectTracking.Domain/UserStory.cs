using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingServices.Entities
{
    public class UserStory
    {
        public UserStory()
        {
            this.ProjectTasks = new HashSet<ProjectTask>();
        }

        public int UserStoryID { get; set; }
        public string Story { get; set; }
        public Nullable<int> ProjectID { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}