using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.ViewModels.Pages
{
    class AddAccountDialogViewModel : IDialogAware
    {
        public DialogCloseListener RequestClose {  get; set; }

        public string Title { get; set; } = "AddAccount";
        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }
    }
}
