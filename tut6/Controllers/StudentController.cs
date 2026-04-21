using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tut6.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name, int numtimes)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}