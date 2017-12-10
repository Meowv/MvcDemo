using MvcControllerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcControllerApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return View(); // 默认情况下不给参数返回和方法同名的视图，即使用视图 Index.cshtml 路径在当前控制器对应的View目录下面

            //return View("OtherIndex"); //使用OtherIndex.cshtml

            //return View("~/Views/Home/Test.cshtml");

            ViewBag.UserName = "小李飞刀";
            ViewData["UserName"] = "陆小凤";
            TempData["UserName"] = "楚留香";
            Customers model = new Customers { ContactName = "谢晓峰" };

            return View(model); //相当于 ViewData.Model = model;
        }

        public ActionResult UpdateCustomerInfo()
        {
            return View();
        }
        
        /// <summary>
        /// Request.Form
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public string UpdateCustomerInfo(FormCollection form)
        {
            return Request.Form["ContactName"];
        }

        /// <summary>
        /// 直接使用 FormCollection来调用
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        //[HttpPost]
        //public string UpdateCustomerInfo(FormCollection form)
        //{
        //    return form["ContactName"];
        //}

        /// <summary>
        /// 在Action中使用同名参数
        /// </summary>
        /// <param name="ContactName"></param>
        /// <returns></returns>
        //[HttpPost]
        //public string UpdateCustomerInfo(string ContactName)
        //{
        //    return ContactName;
        //}

        /// <summary>
        /// 接收Model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //[HttpPost]
        //public string UpdateCustomerInfo(Customers model)
        //{
        //    return model.ContactName + "," + model.CompanyName;
        //}
    }
}