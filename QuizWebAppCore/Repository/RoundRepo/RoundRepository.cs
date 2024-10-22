using Dapper;
using QuizWebAppCore.Data;
using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository.RoundRepo;

public  class RoundRepository : GenericRepository<Round>, IRoundRepository
{
    private readonly DapperContext _context;
    public RoundRepository(DapperContext context) : base(context)
    {
        _context = context;
    }
    public List<Round> GetRoundList(int id = 0, string roundName = "")
    {
        string sql = "SELECT * FROM Round WHERE 1=1"; // 1=1 allows for dynamic filtering

        if (id > 0)
            sql += " AND RoundId = @Id";

        if (!string.IsNullOrEmpty(roundName))
            sql += " AND RoundName = @RoundName";

        sql += " ORDER BY RoundSequenceOrder";

        using (var connection = _context.CreateConnection())
        {
            var lst = connection.Query<Round>(sql, new { Id = id, RoundName = roundName }).ToList();
            return lst;
        }
    }


}
