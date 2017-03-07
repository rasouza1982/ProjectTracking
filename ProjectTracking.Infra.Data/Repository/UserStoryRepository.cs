using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Repository
{
    public class UserStoryRepository : Repository<UserStory>, IUserStoryRepository
    {
        private readonly ProjectTrackingDataContext _context;

        public UserStoryRepository(ProjectTrackingDataContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<UserStory> FindByName(string name)
        {
            return _context.UserStories.Where(x => x.Story.Contains(name)).ToList();
        }
    }
}