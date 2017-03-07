using System.Collections.Generic;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> FindByName(string name); 
    }
}