using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Mapping
{
    public class ProjectTaskMap : EntityTypeConfiguration<ProjectTask>
    {
        public ProjectTaskMap()
        {
            ToTable("ProjectTasks");

            HasKey(x => x.ProjectTaskID);
            Property(x => x.ProjectTaskID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AssignedTo).IsOptional();
            Property(x => x.TaskStartDate).IsOptional();
            Property(x => x.TaskEndDate).IsOptional();
            Property(x => x.TaskCompletion).IsOptional();
            Property(x => x.UserStoryID).IsOptional();
        }
    }
}