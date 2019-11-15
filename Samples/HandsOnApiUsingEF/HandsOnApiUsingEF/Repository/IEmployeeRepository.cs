using HandsOnApiUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApiUsingEF.Repository
{
   public interface IEmployeeRepository
    {
        void Add(Employee item);
        List<Employee> GetAll();
        Employee GetById(int id);
        void Update(Employee item);
        void Delete(int id);
    }
}
