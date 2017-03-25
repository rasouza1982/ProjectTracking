using System.Collections.Generic;
using System.Linq;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Repository
{
    public class ManagerCommentRepository : Repository<ManagerComment>, IManagerCommentRepository
    {
        private readonly ProjectTrackingDataContext _context;

        public ManagerCommentRepository(ProjectTrackingDataContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<ManagerComment> FindByName(string name)
        {
            return _context.ManagerComments.Where(x => x.Comments.Contains(name)).ToList();
        }
    }
}