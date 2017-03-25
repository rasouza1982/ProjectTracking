using System.Collections.Generic;
using System.Linq;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTracking.Infra.Data.DataContext;
using ProjectTrackingServices.Entities;

namespace ProjectTracking.Infra.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        private readonly ProjectTrackingDataContext _context;

        public EmployeeRepository(ProjectTrackingDataContext context)
            :base(context)
        {
            _context = context;
        }

        //public IEnumerable<Employee> GetAll()
        //{
        //    return _context.Employees.ToList();
        //    //var query = from employee in _db.Employees
        //    //            select employee;
        //    //return query.ToList();
        //}

        public IEnumerable<Employee> FindByName(string name)
        {
            return _context.Employees.Where(x => x.EmployeeName.Contains(name)).ToList();
            
            //var query = from employee in _db.Employees
            //            where employee.EmployeeName.Contains(employeeName)
            //            select employee;
            //return query.ToList();
        }

        //public Employee Get(int id)
        //{
        //    return _context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
        //}

        //public IEnumerable<Employee> Insert(Employee e)
        //{
        //    _context.Employees.Add(e);
        //    _context.SaveChanges();
        //    return GetAll();
        //}

        //public IEnumerable<Employee> Update(Employee entity)
        //{

        //    _context.Entry<Employee>(entity).State = EntityState.Modified;
        //    _context.SaveChanges();
        //    return GetAll();
        //    //var emp = (from employee in _db.Employees
        //    //           where employee.EmployeeID == e.EmployeeId
        //    //           select employee).SingleOrDefault();
        //    //emp.EmployeeName = e.EmployeeName;
        //    //emp.Designation = e.Designation;
        //    //emp.ContactNo = e.ContactNo;
        //    //emp.EMailID = e.EMailId;
        //    //emp.SkillSets = e.SkillSets;
        //    //_db.SaveChanges();
        //    //return GetAllEmployees();
        //}

        //public IEnumerable<Employee> Delete(Employee entity)
        //{
        //    _context.Employees.Remove(_context.Employees.Find(entity.EmployeeId));
        //    _context.SaveChanges();
        //    return GetAll();

        //    //throw new NotImplementedException();
        //    //var emp = (from employee in _db.Employees
        //    //           where employee.EmployeeID == e.EmployeeId
        //    //           select employee).SingleOrDefault();
        //    //_db.Employees.Remove(emp);
        //    //_db.SaveChanges();
        //    //return GetAllEmployees();
        //}


        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
    }
}