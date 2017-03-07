using System.Collections.Generic;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IProjectTaskRepository : IRepository<ProjectTask>
    {
        //IEnumerable<ProjectTask> FindByName(string name);
    }
}