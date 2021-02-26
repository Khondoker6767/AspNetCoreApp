using System;
using System.ComponentModel.DataAnnotations;

namespace CoreProject.Models.ViewModes
{
    internal class CustomDateOfBirthAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }
}