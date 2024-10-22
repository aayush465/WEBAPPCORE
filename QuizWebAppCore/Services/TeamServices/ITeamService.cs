using QuizWebAppCore.Models;

namespace QuizWebAppCore.Services.TeamServices
{
    public interface ITeamService
    {
        Task<List<Team>> GetAllTeamListAsync();
    }
}
