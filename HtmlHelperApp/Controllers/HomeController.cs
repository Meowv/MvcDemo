using HtmlHelperApp.Models;
using System.Web.Mvc;

namespace HtmlHelperApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new User { UserName = "阿星Plus", Remark = "大神" });
        }
    }
}