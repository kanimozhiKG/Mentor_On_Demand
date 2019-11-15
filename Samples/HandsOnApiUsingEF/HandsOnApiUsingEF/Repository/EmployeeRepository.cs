using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiUsingEF.Context;
using HandsOnApiUsingEF.Models;
using HandsOnApiUsingEF.Repository;
//using HandsOnAPIUsingEF.Context;
//using HandsOnAPIUsingEF.Models;

namespace HandsOnApiUsingEF.Repository
{
    public class EmployeeRepository : IEmployeeRepository

    {
        private readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }
        public void Add(Employee item)
        {
            _context.employees.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.employees.Find(id);
            _context.employees.Remove(item);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.employees.Find(id);
            //return _context.Employees.SingleOrDefault(i=>i.Eid==id);
        }

        public void Update(Employee item)
        {
            _context.Entry(item).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
