using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Hello from store.index";
        }

        public string Browse(int id)
        {

            string message;

                 message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + id);

            return message;
        }

        public string Details()
        {
            return "Hello from Store.Details()";
        }


        public ActionResult List()
        {


            return View("Index");
        }
    }
}