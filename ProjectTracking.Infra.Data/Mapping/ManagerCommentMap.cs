using System.Data.Entity.ModelConfiguration;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Mapping
{
    public class ManagerCommentMap : EntityTypeConfiguration<ManagerComment>
    {
        public ManagerCommentMap()
        {
            ToTable("ManagerComments");
            
            HasKey(x => x.ManagerCommentId);
            Property(x => x.Comments).IsOptional().HasMaxLength(2000);
            Property(x => x.ProjectTaskId).IsOptional();
            
            HasOptional(t => t.ProjectTask)
              .WithMany(t => t.ManagerComments)
              .HasForeignKey(d => d.ProjectTaskId);
        }
    }
}