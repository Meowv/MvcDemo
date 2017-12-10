using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewApp.Controllers
{
    public class RazorTestController : Controller
    {
        // GET: RazorTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewTemplate()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            ViewData["Msg"] = "Hello world!";

            return PartialView();
        }
    }
}