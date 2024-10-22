using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository;

public interface IUserRepository : IGenericRepository<User>
{
    User CheckUser(string username, string password);
}
