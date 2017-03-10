using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectID);

            // Properties
            this.Property(t => t.ProjectName)
                .HasMaxLength(100);

            this.Property(t => t.ClientName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Projects");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.ProjectName).HasColumnName("ProjectName");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
        }
    }
}
