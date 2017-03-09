using System.Data.Entity.ModelConfiguration;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Mapping
{
    public class UserStoryMap : EntityTypeConfiguration<UserStory>
    {
        public UserStoryMap()
        {
            ToTable("UserStories");

            HasKey(x => x.UserStoryID);
            Property(x => x.Story).HasMaxLength(4000).IsOptional();
            Property(x => x.ProjectID).IsOptional();

            HasOptional(t => t.Project)
                .WithMany(t => t.UserStories)
                .HasForeignKey(d => d.ProjectID);
        }
         
    }
}