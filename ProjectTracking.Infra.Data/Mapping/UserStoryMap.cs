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
            Property(x => x.Story).IsOptional().HasMaxLength(4000);
            Property(x => x.ProjectID).IsOptional();
        }
         
    }
}