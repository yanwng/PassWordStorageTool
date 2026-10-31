using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PassWordStorageTool.Entitys
{
    /// <summary>
    /// 用户类，存储用户登录该程序的账户密码
    /// </summary>
    public class User:BindableBase
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set { SetProperty(ref field, value); } }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set { SetProperty(ref field, value); } }

        /// <summary>
        /// 该用户所下保存的全部账户密码
        /// </summary>
        public ObservableCollection<UserPassWordInfo> Accounts { get; set; }


    }
}
