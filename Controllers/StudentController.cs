using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Btvn_3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "string_name";
            TempData["Age"] = "string_age";
            TempData["Address"] = "string_address";

            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}