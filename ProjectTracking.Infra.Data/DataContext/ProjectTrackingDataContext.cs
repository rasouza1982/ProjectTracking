using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracking.Infra.Data.Mapping;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.DataContext
{
    public class ProjectTrackingDataContext : DbContext
    {
        public ProjectTrackingDataContext()
            : base("ProjectTrackingConnectionString")
        {
            //Database.SetInitializer<BookStoreDataContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ManagerComment> ManagerComments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<UserStory> UserStories{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
#if DEBUG
            Database.Log = s => Debug.Write(s);
#endif

            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ManagerCommentMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new ProjectTaskMap());
            modelBuilder.Configurations.Add(new UserStoryMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
