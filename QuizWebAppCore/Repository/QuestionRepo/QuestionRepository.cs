
using Dapper;
using QuizWebAppCore.Data;
using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;
using QuizWebAppCore.Repository.RoundRepo;

namespace QuizWebAppCore.Repository;

public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
{
    private readonly DapperContext _context;
    public QuestionRepository(DapperContext context) : base(context)
    {
        _context = context;
    }
    public User CheckUser(string username, string password)
    {
        string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

        using (var connection = _context.CreateConnection())
        {
            var user = connection.Query<User>(query, new { Username = username, Password = password }).FirstOrDefault();
            return user;
        }
    }

    public List<Round> GetRoundList(int id = 0, string roundName = "")
    {
        throw new NotImplementedException();
    }
}
