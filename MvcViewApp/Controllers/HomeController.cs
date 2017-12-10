using MvcViewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*
                弱类型：ViewData[""]
                动态型：ViewBag //dynamic
                强类型：Model
                临时存储：TempData[""]
                后台：return View(data); // 存入 ViewData.Model
                前台：Model //其实就是 WebViewPage.Model
             */

            ViewData["One"] = "天机老人孙老头";
            ViewBag.Two = "子母龙凤环上官金虹";
            var user = new User { Name = "下李飞刀李寻欢" };
            TempData["Four"] = "嵩阳铁剑郭嵩阳";

            return View(user);
            //ViewData.Model = user;
        }
    }
}