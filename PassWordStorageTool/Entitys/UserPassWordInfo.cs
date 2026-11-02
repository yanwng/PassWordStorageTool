using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.Entitys
{
    /// <summary>
    /// 用户存储密码的的详细信息
    /// </summary>
    public class UserPassWordInfo:BindableBase
    {
        public UserPassWordInfo()
        {
            
        }
        public UserPassWordInfo(string userName, string passWord, string description, string webSite)
        {
            UserName = userName;
            PassWord = passWord;
            Description = description;
            WebSite = webSite;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set { SetProperty(ref field, value); } }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set { SetProperty(ref field, value); } }
        /// <summary>
        /// 账户描述
        /// </summary>
        public string Description { get; set { SetProperty(ref field, value); } }
        /// <summary>
        /// 那个网站的账户
        /// </summary>
        public string WebSite { get; set { SetProperty(ref field, value); } }




    }
}
