using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.ViewModels
{
    public class MainWindowViewModel:BindableBase
    {
        public User LoginUser { get; set { SetProperty(ref field, value); } }

        /// <summary>
        /// 打开添加账户密码的弹窗
        /// </summary>
        public DelegateCommand OpenAddAccountPage => field ?? (field = new DelegateCommand(() => { DialogService.ShowDialog("AddAccountDialogView"); }));

        public IDialogService DialogService { get; set; }
        public MainWindowViewModel( User user,IDialogService dialogService)
        {
            LoginUser = user;
            DialogService = dialogService;
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
