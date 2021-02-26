using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models.ViewModes
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required, EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        [ValidEmailDomain(allowedDomain: "gmail.com")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Passwprd")]
        [Required, DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password andconfirm password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
