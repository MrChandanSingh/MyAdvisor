using CachingMgt.Models;
using CachingMgt.SessionMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingMgt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserSession _userSession;
        public HomeController(IUserSession userSession)
        {
            _userSession = userSession;
        }
        public ActionResult Index()
        {
            var userInfo = new UserInfo
            {
                Email = "xyz@example.com",
                GuidId = new Guid(),
                Password = "12345"
            };
            _userSession.SetUserInfo(userInfo);
            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";
            ViewBag.GuidId = _userSession.GetUserInfo().GuidId;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}