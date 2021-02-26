using EmployeeManagement.Models.CustomAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(50, ErrorMessage ="Name should not excede more than 50 characters")]        
        public string Name { get; set; }
        [JoiningDate]
        public DateTime JoiningDate { get; set; }

        [Required]
        [Display(Name = "Official Email")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Invalid format of mail")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
        public string ImageUrl { get; set; }

    }
}
