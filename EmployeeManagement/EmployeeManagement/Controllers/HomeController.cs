using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        

        //public IActionResult Details(int id)
        //{
        //    Employee obj = _employeeRepository.GetEmployeeById(id);


        //    // 3 ways of showing data using interfaces
        //    // ViewData["Employee"] = obj; ViewData dictionary of weakly typed object; ViewBag is dynamic type,wrapper of ViewData;
        //    // ViewBag.Employee = obj; 
        //    //strongly typed is just by sending object; And set model reference to view;
        //    return View(obj);
        //}
    }
}
