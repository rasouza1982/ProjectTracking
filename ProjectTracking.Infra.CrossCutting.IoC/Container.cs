using System.Web.Http;
using Microsoft.Practices.Unity;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTracking.Infra.Data.Repository;

namespace ProjectTracking.Infra.CrossCutting.IoC
{
    public static class Container
    {
        public static UnityContainer UnityContainer(HttpConfiguration configuration)
        {
            var container = new UnityContainer();

            container.RegisterType<ProjectTrackingDataContext, ProjectTrackingDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmployeeRepository, EmployeeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IManagerCommentRepository, ManagerCommentRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProjectRepository, ProjectRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProjectTaskRepository, ProjectTaskRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStoryRepository, UserStoryRepository>(new HierarchicalLifetimeManager());
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            //configuration.DependencyResolver = new UnityDependencyResolver(container);
            return container;
        }
    }
}