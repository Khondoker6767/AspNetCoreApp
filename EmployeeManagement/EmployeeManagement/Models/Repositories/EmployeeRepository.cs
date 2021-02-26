using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id=1, Name="Farhad", Department=Dept.HR, Email="farhad@gmail.com" },
                new Employee() { Id=2, Name="Ali", Department=Dept.IT, Email="ali@gmail.com"},
                new Employee() { Id=3, Name="khondoker", Department=Dept.Accounting, Email="khondoker@gmail.com"}
            };

        }

        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = this._employeeList.FirstOrDefault(e =>e.Id == id);
            return employee;
        }

        //public void SaveEmployee(Employee obj)
        //{
        //    throw new NotImplementedException();
        //}

        public Employee UpdateEmployee(Employee obj)
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeRepository.SaveEmployee(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
