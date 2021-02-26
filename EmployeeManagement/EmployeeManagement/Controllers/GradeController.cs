using CoreProject.BLL.Interfaces;
using CoreProject.Models;
using CoreProject.Models.Classes;
using CoreProject.Models.ViewModes;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class GradeController : Controller
    {
        private readonly IplayerRepository _repoObj;
        private readonly AppDbContext _context;

        public GradeController(IplayerRepository repoObj, AppDbContext context)
        {
            _repoObj = repoObj;
            _context = context;
        }
        public ActionResult GradeList(int pageNumber = 1)
        {
            List<Grade> gradeList = _repoObj.GetGrades();
            return View(gradeList);
        }
        [HttpGet]
        public ActionResult AddGrade()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGrade(CreateGradeViewModel viewobj)
        {
            Grade gradeObj = new Grade();
            gradeObj.GradeName = viewobj.GradeName;
            _repoObj.SaveGrade(gradeObj);
            RedirectToAction("GradeList");
            return RedirectToAction("GradeList");
        }
        [HttpGet]
        public ActionResult EditGrade(int id)
        {
            Grade gradeObj = _context.grades.SingleOrDefault(g => g.GradeID == id);
            CreateGradeViewModel gradeObj2 = new CreateGradeViewModel();
            if (gradeObj != null)
            {
               // gradeObj = new Grade();
                gradeObj2.GradeName = gradeObj.GradeName;
            }
            
            return View(gradeObj);
        }
        [HttpPost]
        public ActionResult EditGrade(CreateGradeViewModel viewObj)
        {
            Grade gradeObj = new Grade();
            gradeObj.GradeName = viewObj.GradeName;
            gradeObj.GradeID = viewObj.GradeID;
            _repoObj.UpdateGrade(gradeObj);
            return RedirectToAction("GradeList");
        }
        public ActionResult DeleteGrate(int id)
        {
            Grade gradeobj = _repoObj.GetGradeById(id);
            if (gradeobj != null)
            {
                _repoObj.DeleteGrade(gradeobj.GradeID);
                return RedirectToAction("GradeList");
            }
            return View(gradeobj);
        }
    }
}
