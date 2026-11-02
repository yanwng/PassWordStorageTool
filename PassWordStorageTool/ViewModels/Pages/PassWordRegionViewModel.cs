using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.ViewModels.Pages
{
    public class PassWordRegionViewModel:BindableBase
    {
        public User LoginUser { get; set { SetProperty(ref field, value); } }

        private IDialogService DialogService;

        public DelegateCommand<UserPassWordInfo> Updata => field ?? (new DelegateCommand<UserPassWordInfo>(Updata_method));

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
