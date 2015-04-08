using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Andrew = DateTime.Now.ToShortDateString();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Andrew()
        {
            ViewBag.Andrew = "This was set from the controller";
            ViewBag.Message = "Andrew Was 'ere.";

            return View("About");
        }
    }
}