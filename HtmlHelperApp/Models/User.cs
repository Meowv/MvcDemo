using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HtmlHelperApp.Models
{
    
    public class User
    {
        [DisplayName("用户名")]
        public string UserName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }
    }
}