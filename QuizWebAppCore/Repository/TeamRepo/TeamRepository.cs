using Dapper;
using QuizWebAppCore.Data;
using QuizWebAppCore.Models;

namespace QuizWebAppCore.Repository.TeamRepo;

public class TeamRepository : ITeamRepository
{
    private readonly DapperContext _context;

    public TeamRepository(DapperContext context) 
    {
        _context = context;
    }

    public async Task<List<Team>> GetAllTeamAsync()
    {
        try
        {
            using (var db = _context.CreateConnection())
            {
                string sql = "SELECT * FROM team";
                var teams = await db.QueryAsync<Team>(sql);
                return teams.AsList();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

}
