using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class ManagerCommentMap : EntityTypeConfiguration<ManagerComment>
    {
        public ManagerCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerCommentID);

            // Properties
            this.Property(t => t.Comments)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("ManagerComments");
            this.Property(t => t.ManagerCommentID).HasColumnName("ManagerCommentID");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.ProjectTaskID).HasColumnName("ProjectTaskID");

            // Relationships
            this.HasOptional(t => t.ProjectTask)
                .WithMany(t => t.ManagerComments)
                .HasForeignKey(d => d.ProjectTaskID);

        }
    }
}
