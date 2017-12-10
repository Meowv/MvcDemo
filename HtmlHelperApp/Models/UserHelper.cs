using HtmlHelperApp.Models;

namespace System.Web.Mvc
{
    public static class UserHelper
    {
        public static string UserShow(this HtmlHelper<User> helper)
        {
            var user = helper.ViewData.Model;
            if (user.UserName == "阿星Plus")
            {
                return string.Format("<div>我是{0}</div>", user.UserName);
            }
            else
            {
                return "<div>找不到</div>";
            }
        }
    }
}