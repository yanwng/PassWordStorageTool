using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.ViewModels.Pages
{
    public class PassWordRegionViewModel:BindableBase
    {
        public User LoginUser    { get; set { SetProperty(ref field, value); } }

        public PassWordRegionViewModel(User _LoginUser)
        {
            LoginUser = _LoginUser;
            
        }

    }
}
