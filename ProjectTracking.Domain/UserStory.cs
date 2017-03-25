using System.Collections.Generic;

namespace ProjectTrackingServices.Entities
{
    public class UserStory
    {
        public UserStory()
        {
            ProjectTasks = new HashSet<ProjectTask>();
        }

        public int UserStoryID { get; set; }
        public string Story { get; set; }
        public int? ProjectID { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}