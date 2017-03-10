using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class Project
    {
        public Project()
        {
            this.UserStories = new List<UserStory>();
        }

        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ClientName { get; set; }
        public virtual ICollection<UserStory> UserStories { get; set; }
    }
}
