using MvcAppPager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

namespace MvcAppPager.Controllers
{
    public class HomeController : Controller
    {
        List<Order> list = new List<Order> { new Order { ID = 1, OrderNo = "2016050501", WayFee = 20,EMS="C01111" }, 
             new Order { ID = 2, OrderNo = "2016050502", WayFee = 10,EMS="C01222" },
             new Order { ID = 3, OrderNo = "201605050203", WayFee = 10,EMS="C01222" }, new Order { ID = 4, OrderNo = "201605050204", WayFee = 10,EMS="C01222" }, 
             new Order { ID = 5, OrderNo = "201605050205", WayFee = 10,EMS="C01222" }, new Order { ID = 6, OrderNo = "201605050206", WayFee = 10,EMS="C01222" }};
        private const int PageSize = 2;
        private int counts;

        public ActionResult Index(int pageIndex = 0)
        {
            counts = list.Count;
            list = list.Skip(PageSize * pageIndex).Take(PageSize).ToList();
            PageOfList<Order> _orderList = new PageOfList<Order>(list, pageIndex, PageSize, counts);
            return View(_orderList);
        }

        public ActionResult MvcPager(int id = 1)
        {
            counts = list.Count;
            PagedList<Order> lst = list.AsQueryable().ToPagedList(id, PageSize);
            lst.TotalItemCount = counts;
            lst.CurrentPageIndex = id;
            return View(lst);
        }

        public ActionResult MvcPagerAjax(int id = 1)
        {
            counts = list.Count;
            PagedList<Order> lst = list.AsQueryable().ToPagedList(id, PageSize);
            lst.TotalItemCount = counts;
            lst.CurrentPageIndex = id;
            if (Request.IsAjaxRequest())//如果是Ajax请求
            {
                return PartialView("OrderList", lst);
            }
            else
            {
                return View(lst);
            }
        }
    }
}
