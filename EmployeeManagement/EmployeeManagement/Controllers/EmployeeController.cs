using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace EmployeeManagement.Controllers
    
{
   
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EmployeeController(IEmployeeRepository employeeRepository, IHostingEnvironment hostingEnvironment)
        {
            _employeeRepository = employeeRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Index(string SearchString, string CurrentFilter, string sortOrder, int? Page)
        {
            ViewBag.SortNameParam = string.IsNullOrEmpty(sortOrder) ? "name_des" : "";
            if (SearchString != null)
            {
                Page = 1;
            }
            else
            {
                SearchString = CurrentFilter;
            }
            ViewBag.CurrentFilter = SearchString;

            List<Employee> employeeCreates = _employeeRepository.GetAllEmployees().ToList();

            if (!string.IsNullOrEmpty(SearchString))
            {
                employeeCreates = employeeCreates.Where(n => n.Name.ToUpper().Contains(SearchString.ToUpper())).ToList();
            }
            switch (sortOrder)
            {
                case "name_des":
                    employeeCreates = employeeCreates.OrderByDescending(n => n.Name).ToList();
                    break;
                default:
                    employeeCreates = employeeCreates.OrderBy(n => n.Name).ToList();
                    break;
            }
            int PageSize = 2;
            int PageNumber = (Page ?? 1);
            return View("Index", employeeCreates.ToPagedList(PageNumber, PageSize));
        }
        //public IActionResult Index()
        //{
        //    List<Employee> list = _employeeRepository.GetAllEmployees().ToList();
        //    return View(list);
        //}
        public ViewResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel viewobj)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadFile(viewobj);
                Employee obj = new Employee()
                {
                    Name = viewobj.Name,
                    JoiningDate=viewobj.JoiningDate,
                    Email = viewobj.Email,
                    Department = viewobj.Department,
                    ImageUrl = uniqueFileName

                };
                Employee newEmployee = _employeeRepository.SaveEmployee(obj);
                return RedirectToAction("Details", new { id = newEmployee.Id });
            }
            else
            {
                return View();
            }


        }        

        public ViewResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            EditEmployeeViewModel model = new EditEmployeeViewModel
            {
                Id = employee.Id,
                Name=employee.Name,
                JoiningDate = employee.JoiningDate,
                Email =employee.Email,
                Department=employee.Department,
                ExistingPhotoPath=employee.ImageUrl
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditEmployeeViewModel viewObj)
        {
                       
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.GetEmployeeById(viewObj.Id);
                employee.Name = viewObj.Name;
                employee.JoiningDate = viewObj.JoiningDate;
                employee.Email = viewObj.Email;
                employee.Department = viewObj.Department;
                if (viewObj.Photo!=null)
                {
                    if (viewObj.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Images", viewObj.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    employee.ImageUrl = ProcessUploadFile(viewObj);
                }

                Employee newEmployee = _employeeRepository.UpdateEmployee(employee);
                return RedirectToAction("Details", new { id= newEmployee.Id});
            }
            else
                return View(viewObj);

        }


        private string ProcessUploadFile(EmployeeCreateViewModel viewobj)
        {
            string uniqueFileName = null;
            var files = HttpContext.Request.Form.Files;
            foreach (var image in files)
            {
                if (image != null && image.Length > 0)
                {
                    var file = image;
                    var uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("_", "") + file.FileName;
                        using (var fileStream = new FileStream(Path.Combine(uploadFile, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            uniqueFileName = fileName;
                        }
                    }
                }
            }            
            return uniqueFileName;
        }

        public IActionResult Details(int id)
        {
            Employee obj = _employeeRepository.GetEmployeeById(id);            
            return View(obj);
        }
        public IActionResult Delete(int id)
        {
            Employee deleteEmployee = _employeeRepository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
