using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;
using TestSite2.Models;

namespace TestSite2.Controllers
{
    public class HomeController : Controller
    {
        private test2dbEntities objTestdbentities;

        public HomeController()
        {
            objTestdbentities = new test2dbEntities();
        }

        public ActionResult Index()
        {
         
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult getProductlist()
        {
            return Json(new { data = objTestdbentities.products }, JsonRequestBehavior.AllowGet);
        }
    }
}