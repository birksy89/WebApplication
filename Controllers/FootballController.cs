using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

//Andrew adding this to get access to Models
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class FootballController : Controller
    {
        // GET: Index of Football
        public ActionResult Index()
        {
            return View();
        }


        // GET: Football/Details/MUFC ???
        public ActionResult Details(string id, string name)
        {

            if (id == null || name==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.TeamId = id;
            ViewBag.TeamName = name;

            return View();
        }
    }
}