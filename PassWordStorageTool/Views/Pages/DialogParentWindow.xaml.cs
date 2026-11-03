using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PassWordStorageTool.Views.Pages
{
    /// <summary>
    /// DialogParentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DialogParentWindow : Window,IDialogWindow
    {
        public DialogParentWindow()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}
