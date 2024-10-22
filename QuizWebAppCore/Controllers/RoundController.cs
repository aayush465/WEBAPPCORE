//using Microsoft.AspNetCore.Mvc;
//using QuizWebAppCore.Models;
//using QuizWebAppCore.Repository.RoundRepo;
//using QuizWebAppCore.Services.Security;
//using System.Net;

//namespace QuizWebAppCore.Controllers
//{
//    public class RoundController: Controller
//    {
//        private readonly IRoundRepository _roundRepository;
//        private readonly ISecurityService _securityService;
//        private object _securitySerivce;

//        public RoundController(IRoundRepository roundRepository, ISecurityService securityService)

//        {
//            _roundRepository = roundRepository;
//            _securityService = securityService;
//        }

//        public ActionResult Index(int id = 0, string roundname = "")
//        {
//            var check = _securityService.CheckSession(id);
//            if (check == true)
//            {
//                var list = _roundRepository.GetRoundList(id,roundname);
//                return View(list);
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }

//        public ActionResult Details(int? id)
//        {
//            var check = _securitySerivce.CheckSession(id);
//            if (check == true)
//            {
//                if (id == null)
//                {
//                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//                }
//                Round round = db.GetRoundById((int)id);
//                if (round == null)
//                {
//                    return HttpNotFound();
//                }
//                return View(round);
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }
//        public ActionResult Create()
//        {
//            var check = sec.CheckSession(Session["UserId"]);
//            if (check == true)
//            {
//                return View();
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(FormCollection frm)
//        {
//            var check = sec.CheckSession(Session["UserId"]);
//            if (check == true)
//            {
//                Round round = new Round();
//                round.RoundName = frm["RoundName"];
//                round.RoundNameNp = frm["RoundNameNp"];
//                round.RoundSequenceOrder = Convert.ToInt32(frm["RoundSequenceOrder"]);
//                round.RoundDescription = frm["RoundDescription"];
//                round.Status = Convert.ToInt32(frm["Status"]);

//                db.Insert(round);
//                return RedirectToAction("Index", "Round");
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }
//        public ActionResult Edit(int? id)
//        {
//            var check = sec.CheckSession(Session["UserId"]);
//            if (check == true)
//            {
//                if (id == null)
//                {
//                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//                }
//                Round round = db.GetRoundById((int)id);
//                if (round == null)
//                {
//                    return HttpNotFound();
//                }
//                return View(round);
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }

//        [HttpPost]
//        public ActionResult Edit(FormCollection frm, int id)
//        {
//            var check = sec.CheckSession(Session["UserId"]);
//            if (check == true)
//            {
//                Round edit = new Round();
//                edit.RoundName = frm["RoundName"];
//                edit.RoundNameNp = frm["RoundNameNp"];
//                edit.RoundSequenceOrder = Convert.ToInt32(frm["RoundSequenceOrder"]);
//                edit.RoundDescription = frm["RoundDescription"];
//                edit.Status = Convert.ToInt32(frm["Status"]);
//                //if (frm["Status"] == "Yes")
//                //{
//                //    round.Status = true;
//                //}
//                //else
//                //{
//                //    round.Status = false;
//                //}
//                db.Update(edit, id);
//                return RedirectToAction("Index", "Round");
//            }
//            else
//            {
//                return RedirectToAction("Logout", "User");
//            }
//        }

//    }
//}
