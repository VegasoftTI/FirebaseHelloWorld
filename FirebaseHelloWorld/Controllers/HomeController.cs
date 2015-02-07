using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirebaseHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FirebaseParteUm()
        {
            return View();
        }

        public ActionResult FirebaseParteDois()
        {

            return View();
        }

        public ActionResult FirebaseParteTres()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}