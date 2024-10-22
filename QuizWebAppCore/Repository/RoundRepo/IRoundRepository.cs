using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository.RoundRepo;

public interface IRoundRepository : IGenericRepository<Round>
{
    List<Round> GetRoundList(int id = 0, string roundName = "");

}

