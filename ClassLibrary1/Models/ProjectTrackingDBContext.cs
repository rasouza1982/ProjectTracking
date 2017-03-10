using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ClassLibrary1.Models.Mapping;

namespace ClassLibrary1.Models
{
    public partial class ProjectTrackingDBContext : DbContext
    {
        static ProjectTrackingDBContext()
        {
            Database.SetInitializer<ProjectTrackingDBContext>(null);
        }

        public ProjectTrackingDBContext()
            : base("Name=ProjectTrackingDBContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ManagerComment> ManagerComments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<UserStory> UserStories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ManagerCommentMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new ProjectTaskMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserStoryMap());
        }
    }
}
