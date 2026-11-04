using PassWordStorageTool.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PassWordStorageTool.ViewModels.Pages
{
    public class ConfirmWindowViewModel : IDialogAware
    {
        public DialogCloseListener RequestClose {  get; set; }

        public UserPassWordInfo  PassInfo  { get; set; }

        public DialogResult Result { get; set; }

        public DelegateCommand<Window> ConfirmYesCommand => 
            field ?? (field = new DelegateCommand<Window>(win => 
            {      Result = new DialogResult();
                    Result.Result = ButtonResult.Yes;
                win.Close();
            }));

        public DelegateCommand<Window> ConfirmNoCommand =>
            field ?? (field = new DelegateCommand<Window>(win =>
            {
                Result = new DialogResult();
                Result.Result = ButtonResult.No;
                win.Close();
            }));

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            if (Result == null)
            {
                Result = new DialogResult();
                Result.Result = ButtonResult.No;
            }
            RequestClose.Invoke(Result);   
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            PassInfo = parameters.GetValue<UserPassWordInfo>("info");
        }

        
    }
}
