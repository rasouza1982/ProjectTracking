using System.Collections.Generic;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> FindByName(string name);
    }
}