using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CERTIVAL.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ayuda del Sistema CERTIVAL.";

            return View();
        }
        public ActionResult Ayuda()
        {
            ViewBag.Message = "Ayuda del Sistema CERTIVAL.";

            return View();
        }
        public ActionResult AvisoConformidad()
        {
            ViewBag.Message = "Ayuda del Sistema CERTIVAL.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}