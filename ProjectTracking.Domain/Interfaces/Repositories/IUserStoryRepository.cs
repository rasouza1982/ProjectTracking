using System.Collections.Generic;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IUserStoryRepository : IRepository<UserStory>
    {
        IEnumerable<UserStory> FindByName(string name);
    }
}