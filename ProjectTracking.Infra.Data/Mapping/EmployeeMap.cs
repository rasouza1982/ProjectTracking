using System.Data.Entity.ModelConfiguration;
using ProjectTrackingServices.Entities;


namespace ProjectTracking.Infra.Data.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {

         public EmployeeMap()
        {
            ToTable("Employees");

            HasKey(x => x.EmployeeId);
            Property(x => x.EmployeeName).HasMaxLength(100).IsOptional();
            Property(x => x.Designation).HasMaxLength(100).IsOptional();
            Property(x => x.ManagerId).IsOptional();
            Property(x => x.ContactNo).HasMaxLength(15).IsOptional();
            Property(x => x.EMailId).HasMaxLength(30).IsOptional();
            Property(x => x.SkillSets).HasMaxLength(100).IsOptional();
         }

    }
}