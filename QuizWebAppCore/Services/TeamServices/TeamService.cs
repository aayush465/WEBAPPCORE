using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.TeamRepo;

namespace QuizWebAppCore.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        #region ctor and prop

        private readonly ITeamRepository _teamRepository;
        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        #endregion

        #region Methods
        public async Task<List<Team>> GetAllTeamListAsync()
        {
            var response =  await _teamRepository.GetAllTeamAsync().ConfigureAwait(false);
            return response.ToList();       
        }

        #endregion


    }
}
