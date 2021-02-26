using CoreProject.BLL.Interfaces;
using CoreProject.Models.Classes;
using CoreProject.Models.ViewModes;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreProject.BLL.Repository
{
    public class PlayersRepository : IplayerRepository
    {
        private readonly AppDbContext _context;

        public PlayersRepository(AppDbContext context)
        {
            _context = context;
        }
        public void DeleteGrade(int id)
        {
            Grade delGrade = GetGradeById(id);
            _context.grades.Remove(delGrade);
            _context.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            Player delPlayer = GetPlayerById(id);
            _context.players.Remove(delPlayer);
            _context.SaveChanges();
        }

        public List<CreatePlayerModel> GetCreatePlayers()
        {
            List<CreatePlayerModel> createPlayerModels = new List<CreatePlayerModel>();
            createPlayerModels = _context.players.Select(p => new CreatePlayerModel
            {
                Name = p.Name,
                DoB = p.DoB,
                Team = p.Team,
                Email = p.Email,
                Phone = p.Phone,
                Salary = p.Salary,
                ImageName = p.ImageName,
                ImageUrl = p.ImageUrl,
                GradeID = p.Grade.GradeID
            }).ToList();
            return createPlayerModels;
        }

        public Grade GetGradeById(int GradeID)
        {
            Grade grade = _context.grades.SingleOrDefault(g => g.GradeID == GradeID);
            return grade;
        }

        public List<Grade> GetGrades()
        {
            List<Grade> gradeList = _context.grades.ToList();
            return gradeList;
        }

        public Player GetPlayerById(int id)
        {
            Player player = _context.players.SingleOrDefault(p => p.PlayerID == id);
            return player;
        }

        public List<PlayerListViewModel> GetPlayerList()
        {
            List<PlayerListViewModel> list = _context.players.Select(p => new PlayerListViewModel
            {
                PlayerID = p.PlayerID,
                Name = p.Name,
                DoB = p.DoB,
                Team = p.Team,
                Email = p.Email,
                Phone = p.Phone,
                Salary = p.Salary,
                ImageName = p.ImageName,
                ImageUrl = p.ImageUrl,
                GradeID = p.GradeID,
                GradeName = p.Grade.GradeName,
            }).ToList();
            return list;
        }

        public void SaveGrade(Grade obj)
        {
            _context.grades.Add(obj);
            _context.SaveChanges();
        }

        public void SavePlayer(Player obj)
        {
            _context.players.Add(obj);
            _context.SaveChanges();
        }

        public void UpdateGrade(Grade obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdatePlayer(Player obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
