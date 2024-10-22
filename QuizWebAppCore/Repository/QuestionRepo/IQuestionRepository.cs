using QuizWebAppCore.Models;
using QuizWebAppCore.Repository.GenericRepository;

namespace QuizWebAppCore.Repository.RoundRepo;

public interface IQuestionRepository : IGenericRepository<Question>
{
    List<Round> GetRoundList(int id = 0, string roundName = "");

}

 