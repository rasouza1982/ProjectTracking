using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class ManagerComment
    {
        public int ManagerCommentID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> ProjectTaskID { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
    }
}
