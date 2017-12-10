using System.Linq;
using System.Web.Mvc;

namespace MvcModelApp.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tb_User model)
        {
            if (ModelState.IsValid)
            {
                db.tb_User.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public JsonResult NotExitesUserName()
        {
            string UserName = Request.Params["UserName"];

            var user = db.tb_User.Where(x => x.UserName == UserName).FirstOrDefault();
            return user == null ? Json(true, JsonRequestBehavior.AllowGet) : Json(false, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            var user = db.tb_User.ToList();
            return View(user);
        }
    }
}
