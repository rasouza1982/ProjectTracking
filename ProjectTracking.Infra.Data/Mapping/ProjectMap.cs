using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            ToTable("Projects");
            
            HasKey(x => x.ProjectId);
            Property(x => x.ProjectId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ProjectName).IsOptional().HasMaxLength(100);
            Property(x => x.StartDate).IsOptional();
            Property(x => x.EndDate).IsOptional();
            Property(x => x.ClientName).IsOptional().HasMaxLength(100);

        }
         
    }
}