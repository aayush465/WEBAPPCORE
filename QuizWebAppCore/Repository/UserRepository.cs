using Dapper;
using QuizWebAppCore.Data;
using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly DapperContext _context;
    public UserRepository(DapperContext context) : base(context)
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
}
