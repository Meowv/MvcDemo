using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcModelApp
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        {
        }
    }

    [MetadataType(typeof(UserMetadata))]
    public partial class tb_User
    {
        public string RePwd { get; set; }
    }

    //为实体类添加特性DisplayName
    public class UserMetadata
    {
        [DisplayName("用户名")]
        [Remote("NotExitesUserName", "Home", ErrorMessage = "用户账号已存在")]
        public string UserName { get; set; }

        /// <summary>
        /// 在实体类中为Remark属性设置DataType特性，指定为多行文本框
        /// </summary>
        [DataType(DataType.MultilineText)]
        [DisplayName("备注")]
        public string Remark { get; set; }

        [DisplayName("年龄")]
        [Range(1, 120)]
        public int Age { get; set; }

        [PasswordPropertyText]
        [DisplayName("密码")]
        public string Pwd { get; set; }

        [PasswordPropertyText]
        [DisplayName("确认密码")]
        [System.Web.Mvc.Compare("Pwd")]
        public string RePwd { get; set; }

        [Email]
        public string Email { get; set; }
    }
}