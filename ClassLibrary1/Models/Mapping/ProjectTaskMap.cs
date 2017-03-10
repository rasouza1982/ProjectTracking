using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class ProjectTaskMap : EntityTypeConfiguration<ProjectTask>
    {
        public ProjectTaskMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectTaskID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProjectTasks");
            this.Property(t => t.ProjectTaskID).HasColumnName("ProjectTaskID");
            this.Property(t => t.AssignedTo).HasColumnName("AssignedTo");
            this.Property(t => t.TaskStartDate).HasColumnName("TaskStartDate");
            this.Property(t => t.TaskEndDate).HasColumnName("TaskEndDate");
            this.Property(t => t.TaskCompletion).HasColumnName("TaskCompletion");
            this.Property(t => t.UserStoryID).HasColumnName("UserStoryID");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.ProjectTasks)
                .HasForeignKey(d => d.AssignedTo);
            this.HasOptional(t => t.UserStory)
                .WithMany(t => t.ProjectTasks)
                .HasForeignKey(d => d.UserStoryID);

        }
    }
}
