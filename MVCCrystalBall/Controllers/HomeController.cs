using MVCCrystalBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrystalBall.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ShakeBall()
        {
            //create an object of type CrystalBall
            CrystalBall ball = new CrystalBall();
            string reply = ball.getResponses();
            return Json(reply, JsonRequestBehavior.AllowGet);
        }
    }
}