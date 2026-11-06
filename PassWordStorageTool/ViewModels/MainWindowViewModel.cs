using PassWordStorageTool.Entitys;
using PassWordStorageTool.HelpClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public MainWindowViewModel( User user,IDialogService dialogService,IEventAggregator eventAggregator)
        {
            LoginUser = user;
            DialogService = dialogService;
            LoadAllUserPassWordInfo();

            eventAggregator.GetEvent<SaveAccountEvent>().Subscribe(SaveAccount,ThreadOption.BackgroundThread);
        }

        /// <summary>
        /// 存储的账户发生变动，需要序列化存储
        /// </summary>
        private void SaveAccount()
        {
           string json = JsonSerializer.Serialize<ObservableCollection<UserPassWordInfo>>(LoginUser.Accounts);

            using (FileStream stream = new FileStream("Accounts.txt", FileMode.Create))
            {
                string key = EncryptionHelper.EncryptionKey(json);
                stream.Write(Encoding.UTF8.GetBytes(key));
            }
        }

        /// <summary>
        /// 加载该用户的所有账户密码
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadAllUserPassWordInfo()
        {
            string json = "";
            if (File.Exists("Accounts.txt")){

                using (FileStream stream = File.OpenRead("Accounts.txt"))
                {
                    byte[] buffer = new byte[10 * 1024];
                    int readLen = 0;

                    do
                    {
                        readLen = stream.Read(buffer, 0, buffer.Length);
                        json += Encoding.UTF8.GetString(buffer, 0, readLen);
                    }
                    while (readLen == 1024);

                }
            }
            else
            {
                File.Create("Accounts.txt").Dispose();
            }
            ObservableCollection<UserPassWordInfo> accounts = new ObservableCollection<UserPassWordInfo>();
            if (json != "")
            {
                string key = EncryptionHelper.DecryptionKey(json);
                accounts = JsonSerializer.Deserialize<ObservableCollection<UserPassWordInfo>>(key);
            }
            LoginUser.Accounts = accounts;
        }

    }


}
