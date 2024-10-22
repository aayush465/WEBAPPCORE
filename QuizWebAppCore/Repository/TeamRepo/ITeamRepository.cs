using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository.TeamRepo
{
    public interface ITeamRepository 
    {
        Task<List<Team>> GetAllTeamAsync();
    }
}
