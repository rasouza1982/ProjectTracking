using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeName)
                .HasMaxLength(100);

            this.Property(t => t.Designation)
                .HasMaxLength(100);

            this.Property(t => t.ContactNo)
                .HasMaxLength(15);

            this.Property(t => t.EMailID)
                .HasMaxLength(30);

            this.Property(t => t.SkillSets)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.EMailID).HasColumnName("EMailID");
            this.Property(t => t.SkillSets).HasColumnName("SkillSets");
        }
    }
}
