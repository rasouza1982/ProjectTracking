using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class UserStoryMap : EntityTypeConfiguration<UserStory>
    {
        public UserStoryMap()
        {
            // Primary Key
            this.HasKey(t => t.UserStoryID);

            // Properties
            this.Property(t => t.UserStoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Story)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("UserStories");
            this.Property(t => t.UserStoryID).HasColumnName("UserStoryID");
            this.Property(t => t.Story).HasColumnName("Story");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");

            // Relationships
            this.HasOptional(t => t.Project)
                .WithMany(t => t.UserStories)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
