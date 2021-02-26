using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Farhad", Email = "farhad@gmail.com", Department = Dept.HR },
                new Employee { Id = 2, Name = "Ali", Email = "farhad@gmail.com", Department = Dept.IT },
                new Employee { Id = 3, Name = "Farhad", Email = "farhad@gmail.com", Department = Dept.Accounting }

                );
        }
    }
}
