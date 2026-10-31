using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.Entitys
{
    /// <summary>
    /// 用户存储密码的的详细信息
    /// </summary>
    public class UserPassWordInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 账户描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 那个网站的账户
        /// </summary>
        public string WebSite { get; set; }
    }
}
