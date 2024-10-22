using Microsoft.AspNetCore.Mvc;
using QuizWebAppCore.Repository.RoundRepo;
using QuizWebAppCore.Services.Security;

namespace QuizWebAppCore.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly ISecurityService _securityService;
        private IQuestionRepository questionRepository;

        public QuestionController(IRoundRepository roundRepository, ISecurityService securityService)

        {
            _questionRepository = questionRepository;
            _securityService = securityService;
        }

        public ActionResult Index(int id = 0, string roundname = "")
        {
            var check = _securityService.CheckSession(id);
            if (check == true)
            {
                var list = _questionRepository.GetRoundList(id);
                return View(list);
            }
            else
            {
                return RedirectToAction("Logout", "User");
            }
        }



    }
}
