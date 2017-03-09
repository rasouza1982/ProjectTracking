using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Repository
{
    public class ProjectTaskRepository : Repository<ProjectTask>, IProjectTaskRepository
    {
        private readonly ProjectTrackingDataContext _context;

        public ProjectTaskRepository(ProjectTrackingDataContext context)
            : base(context)
        {
            _context = context;
        }

    }
}