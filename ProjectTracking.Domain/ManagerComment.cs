using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingServices.Entities
{
    public class ManagerComment
    {
        public int ManagerCommentId { get; set; }
        public string Comments { get; set; }
        public int? ProjectTaskId { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
    }
}