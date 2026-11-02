using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PassWordStorageTool.ViewModels.Pages
{
    class AddAccountDialogViewModel : BindableBase, IDialogAware
    {
        public DialogCloseListener RequestClose {  get; set; }

        public string Title { get; set; } = "AddAccount";

        private User LoginUser;

        public AddAccountDialogViewModel(User _LoginUser)
        {
            LoginUser = _LoginUser;
        }

        /// <summary>
        /// 绑定界面输入的model
        /// </summary>
        public UserPassWordInfo AddUserPassWordInfo { get; set { SetProperty(ref field, value); } } = new UserPassWordInfo();

        /// <summary>
        /// 退出添加界面
        /// </summary>
        public DelegateCommand<Window> Exit => field ?? (field = new DelegateCommand<Window>(win => { win.Close(); }));

        public DelegateCommand<Window> Submit => field ?? (field = new DelegateCommand<Window>(Submit_method));

        /// <summary>
        /// 提交储存
        /// </summary>
        private void Submit_method(Window win)
        {
            if (IsCanSubmit())
            {
                if(!LoginUser.Accounts.Contains(AddUserPassWordInfo))
                    LoginUser.Accounts.Add(AddUserPassWordInfo);
                win.Close();
            }
            else
            {
                MessageBox.Show("所有项目不能为空","提交提醒",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private bool IsCanSubmit()
        {
            if(AddUserPassWordInfo.UserName==string.Empty|| AddUserPassWordInfo.UserName==null) return false;
            if(AddUserPassWordInfo.PassWord==string.Empty|| AddUserPassWordInfo.PassWord == null) return false;
            if(AddUserPassWordInfo.Description==string.Empty|| AddUserPassWordInfo.Description == null) return false;
            if(AddUserPassWordInfo.WebSite==string.Empty|| AddUserPassWordInfo.WebSite == null) return false;

            return true;
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
           AddUserPassWordInfo  =  parameters.GetValue<UserPassWordInfo>("parameter")?? AddUserPassWordInfo;
        }
    }
}
