using CoreProject.BLL.Interfaces;
using CoreProject.BLL.Repository;
using CoreProject.Models.Classes;
using CoreProject.Models.ViewModes;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    //[Authorize(Roles = "User")]
    public class PlayerController : Controller
    {
        private readonly IplayerRepository _repoObj;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly AppDbContext _context;

        public PlayerController(IplayerRepository repoObj, IHostingEnvironment hostingEnvironment, AppDbContext context)
        {
            _repoObj = repoObj;
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }
        public ActionResult Index(string SearchString, string CurrentFilter, string sortOrder, int? Page)
        {
            ViewBag.SortNameParam = string.IsNullOrEmpty(sortOrder) ? "name_des" : "";
            ViewBag.Salary = string.IsNullOrEmpty(sortOrder) ? "salary_des" : "";
            if (SearchString != null)
            {
                Page = 1;
            }
            else
            {
                SearchString = CurrentFilter;
            }
            ViewBag.CurrentFilter = SearchString;

            List<PlayerListViewModel> playerList = _repoObj.GetPlayerList();

            if (!string.IsNullOrEmpty(SearchString))
            {
                playerList = playerList.Where(n => n.Name.ToUpper().Contains(SearchString.ToUpper())).ToList();
            }
            switch (sortOrder)
            {
                case "name_des":
                    playerList = playerList.OrderByDescending(n => n.Name).ToList();
                    break;
                case "salary_des":
                    playerList = playerList.OrderByDescending(n => n.Salary).ToList();
                    break;
                default:
                    playerList = playerList.OrderBy(n => n.Name).ToList();
                    break;
            }
            int PageSize = 100;
            int PageNumber = (Page ?? 1);
            return View("Index", playerList.ToPagedList(PageNumber, PageSize));


            //List<PlayerListViewModel> list = repoObj.GetPlayerList();
            //return View(list);
        }

        public ActionResult Create()
        {
            CreatePlayerModel crObj = new CreatePlayerModel();
            crObj.gradeList = _context.grades.ToList();
            return View(crObj);
        }
        public ActionResult AddOrEdit(CreatePlayerModel viewObj)
        {
            var result = false;

            string uniqueFile = ProcessUploadFile(viewObj);
            Player playerObj = new Player();
            playerObj.Name = viewObj.Name;
            playerObj.DoB = viewObj.DoB;
            playerObj.Team = viewObj.Team;
            playerObj.Email = viewObj.Email;
            playerObj.Phone = viewObj.Phone;
            playerObj.Salary = viewObj.Salary;
            playerObj.GradeID = viewObj.GradeID;
            //playerObj.ImageName = fileWithExtension;
            playerObj.ImageUrl = uniqueFile;
            //string fileServerPath = Path.Combine(Server.MapPath("~/Images/" + fileName + extension));
            //viewObj.ImageFile.SaveAs(fileServerPath);

            if (ModelState.IsValid)
            {
                if (viewObj.PlayerID == 0)
                {
                    _repoObj.SavePlayer(playerObj);
                    result = true;
                }
                else
                {
                    playerObj.PlayerID = viewObj.PlayerID;
                    _repoObj.UpdatePlayer(playerObj);
                    result = true;
                }
            }
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (viewObj.PlayerID == 0)
                {
                    CreatePlayerModel crObj = new CreatePlayerModel();
                    crObj.gradeList = _context.grades.ToList();
                    return View("Create", crObj);
                }
                else
                {
                    CreatePlayerModel crObj = new CreatePlayerModel();
                    crObj.gradeList = _context.grades.ToList();
                    return View("Edit", crObj);
                }
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            Player playerObj = _repoObj.GetPlayerById(id);
            CreatePlayerModel viewObj = new CreatePlayerModel();
            if (playerObj !=null)
            {
                viewObj.PlayerID = playerObj.PlayerID;
                viewObj.Name = playerObj.Name;
                viewObj.DoB = playerObj.DoB;
                viewObj.Team = playerObj.Team;
                viewObj.Email = playerObj.Email;
                viewObj.Phone = playerObj.Phone;
                viewObj.ImageName = playerObj.ImageName;
                viewObj.Salary = playerObj.Salary;
                viewObj.GradeID = playerObj.GradeID;
                viewObj.gradeList = _context.grades.ToList();
                viewObj.ImageUrl = playerObj.ImageUrl;
            }            
            return View(viewObj);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Player playerObj = _repoObj.GetPlayerById(id);
            CreatePlayerModel viewObj = new CreatePlayerModel();
            if (playerObj != null)
            {
                viewObj.PlayerID = playerObj.PlayerID;
                viewObj.Name = playerObj.Name;
                viewObj.DoB = playerObj.DoB;
                viewObj.Team = playerObj.Team;
                viewObj.Email = playerObj.Email;
                viewObj.Phone = playerObj.Phone;
                viewObj.Salary = playerObj.Salary;
                viewObj.GradeID = playerObj.GradeID;
                viewObj.ImageUrl = playerObj.ImageUrl;
            }
           
            return View(viewObj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            Player playerObj = _repoObj.GetPlayerById(id);
            if (playerObj != null)
            {
                _repoObj.DeletePlayer(playerObj.PlayerID);
                return RedirectToAction("Index");
            }
            return View(playerObj);
        }
        public ActionResult Details(int PlayerID)
        {
            Player playerObj = _repoObj.GetPlayerById(PlayerID);
            PlayerListViewModel viewObj = new PlayerListViewModel();
            viewObj.PlayerID = playerObj.PlayerID;
            viewObj.Name = playerObj.Name;
            viewObj.DoB = playerObj.DoB;
            viewObj.Team = playerObj.Team;
            viewObj.Email = playerObj.Email;
            viewObj.Phone = playerObj.Phone;
            viewObj.Salary = playerObj.Salary;
            viewObj.GradeID = playerObj.GradeID;
            //viewObj.GradeName = playerObj.Grade.GradeName;
            viewObj.ImageUrl = playerObj.ImageUrl;
            return PartialView("_DetailsRecord", viewObj);
        }
        private string ProcessUploadFile(CreatePlayerModel viewobj)
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
                        var fileName =  file.FileName;
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
    }
}
