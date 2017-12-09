using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Item30.Models;
using System.Web.Mvc;

namespace Item30.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }

        public ActionResult Student()
        {
            ViewBag.Message = "";
            return View();
        }
        public ActionResult Courses()
        {
            ViewBag.Message = "";
            return View();
        }
    }
}