using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
   public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        Employee SaveEmployee(Employee obj);
        Employee UpdateEmployee(Employee obj);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();

    }
}
