using CoreProject.Models.Classes;
using CoreProject.Models.ViewModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.BLL.Interfaces
{
    public interface IplayerRepository
    {
        List<PlayerListViewModel> GetPlayerList();
        List<CreatePlayerModel> GetCreatePlayers();
        void UpdatePlayer(Player obj);
        void SavePlayer(Player obj);
        void DeletePlayer(int id);
        Player GetPlayerById(int id);
        List<Grade> GetGrades();
        void SaveGrade(Grade obj);
        void UpdateGrade(Grade obj);
        Grade GetGradeById(int GradeID); 
        void DeleteGrade(int id);
    }
}
