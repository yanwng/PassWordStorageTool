using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Prism.Dialogs;


namespace PassWordStorageTool.ViewModels.Pages
{
    public class PassWordRegionViewModel:BindableBase
    {
        public User LoginUser { get; set { SetProperty(ref field, value); } }

        private IDialogService DialogService;

        public DelegateCommand<UserPassWordInfo> Updata => field ?? (new DelegateCommand<UserPassWordInfo>(Updata_method));
        public DelegateCommand<UserPassWordInfo> Delete => field ?? (new DelegateCommand<UserPassWordInfo>(Delete_method));

        public DelegateCommand OpenAddAccountPage => field ?? (field = new DelegateCommand(() => { DialogService.ShowDialog("AddAccountDialogView"); }));

        /// <summary>
        /// 移除当前选择的一项
        /// </summary>
        /// <param name="info"></param>
        private void Delete_method(UserPassWordInfo info)
        {
            if (info == null) return;
            //MessageBoxResult messageBoxResult = MessageBox.Show($"是否删除{info.UserName}账户密码","删除提醒",MessageBoxButton.YesNo,MessageBoxImage.Question);
            DialogParameters parameter = new DialogParameters();
            parameter.Add("info", info);
            DialogService.Show("ConfirmWindow" ,parameter, Result => 
            {
                if (Result.Result == ButtonResult.Yes)
                    LoginUser.Accounts.Remove(info);
            }, "Confirm");   




        }

        /// <summary>
        /// 更新已有账户密码
        /// </summary>
        /// <param name="info"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Updata_method(UserPassWordInfo info)
        {
            DialogParameters parameters = new DialogParameters();
            parameters.Add("parameter", info);
            DialogService.ShowDialog("AddAccountDialogView",parameters);
        }

        public PassWordRegionViewModel(User _LoginUser,IDialogService dialogService)
        {
            LoginUser = _LoginUser;
            DialogService = dialogService;
        }

    }
}
