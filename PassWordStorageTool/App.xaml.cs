using PassWordStorageTool.Entitys;
using PassWordStorageTool.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PassWordStorageTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return ContainerLocator.Container.Resolve<LoginView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<User>();
            
        }
    }

}
