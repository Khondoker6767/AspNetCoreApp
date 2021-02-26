using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Repositories
{
    public class EmployeeSqlRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeSqlRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }
        public Employee GetEmployeeById(int id)
        {
            Employee employee = GetAllEmployees().FirstOrDefault(e => e.Id == id);
            return employee;
        }
        public Employee SaveEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Employee UpdateEmployee(Employee obj)
        {
            var employee = _context.Employees.Attach(obj);
            employee.State = EntityState.Modified;            
            _context.SaveChanges();
            return obj;
        }
        public Employee DeleteEmployee(int id)
        {
            Employee employee = GetEmployeeById(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }                      
    }
}
