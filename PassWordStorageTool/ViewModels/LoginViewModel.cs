using PassWordStorageTool.Entitys;
using PassWordStorageTool.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PassWordStorageTool.ViewModels
{
    public class LoginViewModel:BindableBase
    {
        /// <summary>
        /// 登录者
        /// </summary>
        public User  LoginUser { get; set { SetProperty(ref field, value); } }


        public LoginViewModel(User _user)
        {
            LoginUser = _user;
            LoginUser.UserName = "admin";
            LoginUser.PassWord = "123456";
            LoginUser.Accounts.Add(new UserPassWordInfo("admin","123456","存储工具的账户密码","https://baidu.com"));
        }

        /// <summary>
        /// 登录命令
        /// </summary>
        public DelegateCommand<Window> LoginCommand  => field?? (field = new DelegateCommand<Window>(Login));
        public DelegateCommand<Window> ExitCommand => field?? (field = new DelegateCommand<Window>(Exit));

        /// <summary>
        /// 退出登录窗口
        /// </summary>
        /// <param name="window"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Exit(Window window)
        {
            window.Close();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Login(Window LoginViewWindow)
        {
            //账户密码对比
            if(LoginUser != null&&LoginUser.UserName=="admin"&&LoginUser.PassWord=="123456")
            {
                //登录成功打开新窗口，关闭登录窗口，加载用户下的账户密码
                ContainerLocator.Container.Resolve<MainWindow>().Show();
                LoginViewWindow.Close();
            }
            else
            {
                MessageBox.Show("账户或密码错误","登录提示",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
