using Microsoft.AspNetCore.Mvc;
using QuizWebAppCore.Models;
using QuizWebAppCore.Repository;
using System.Reflection;

namespace QuizWebAppCore.Controllers
{
    public class UserController : Controller
    {
        #region Ctor & Properties 
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
         
		#endregion


		#region Method

		[HttpGet]
		public IActionResult Login(string returnUrl = null)
		{
			ViewBag.ReturnUrl = returnUrl; 
			return View();
		}

		[HttpPost]
        public ActionResult Login(User model)
        {
            //string userName = frm["UserName"];
            //string password = frm["Password"];

            //var checkUser = _userRepository.CheckUser(userName, password);

            var checkUser = _userRepository.CheckUser(model.UserName, model.Password);

            if (checkUser != null)
            {
                HttpContext.Session.SetString("UserName", checkUser.UserName);
                HttpContext.Session.SetInt32("UserId", checkUser.UserId);
                HttpContext.Session.SetString("UserType", checkUser.UserType);

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Message = "Login Failed!!";
                return View();
            }

        }

        #endregion
    }
}
