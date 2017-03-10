using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class UserStory
    {
        public UserStory()
        {
            this.ProjectTasks = new List<ProjectTask>();
        }

        public int UserStoryID { get; set; }
        public string Story { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
