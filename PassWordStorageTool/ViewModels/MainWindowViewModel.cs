using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.ViewModels
{
    public class MainWindowViewModel:BindableBase
    {
        public User LoginUser { get; set { SetProperty(ref field, value); } }

        public MainWindowViewModel( User user)
        {
            LoginUser = user;
            LoadAllUserPassWordInfo();
        }

        /// <summary>
        /// 加载该用户的所有账户密码
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadAllUserPassWordInfo()
        {
            
        }
    }


}
