using System.Collections.Generic;
using System.Linq;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private readonly ProjectTrackingDataContext _context;

        public ProjectRepository(ProjectTrackingDataContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Project> FindByName(string name)
        {
            return _context.Projects.Where(x => x.ProjectName.Contains(name)).ToList();
        }
    }
}