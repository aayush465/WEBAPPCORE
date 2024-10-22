using Microsoft.AspNetCore.Mvc;
using QuizWebAppCore.Services.TeamServices;

namespace QuizWebAppCore.Controllers
{
    public class TeamController : Controller
    {

        #region
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        #endregion

        #region
        public async Task<ActionResult> Index()
        {
            var data = await _teamService.GetAllTeamListAsync().ConfigureAwait(false);
            return View(data);
        }
        #endregion
    }
}
