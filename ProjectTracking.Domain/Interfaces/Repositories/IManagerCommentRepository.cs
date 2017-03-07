using System.Collections.Generic;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IManagerCommentRepository : IRepository<ManagerComment>
    {
        IEnumerable<ManagerComment> FindByName(string name); 
    }
}