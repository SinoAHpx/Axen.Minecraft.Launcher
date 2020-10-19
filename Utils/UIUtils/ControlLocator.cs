using System.Windows;
using Axen.Minecraft.Launcher.Utils.UIType;
using Axen.Minecraft.Launcher.ViewModels;
using Axen.Minecraft.Launcher.Views.Config;
using Axen.Minecraft.Launcher.Views.Home;

namespace Axen.Minecraft.Launcher.Utils.UIUtils
{
    public class ControlLocator
    {
        public static MainWindow GetMainWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        public static HomeControlView GetHomeControlView()
        {
            return GetMainWindow().HomeControl;
        }

        public static ConfigControlView GetConfigControlView()
        {
            return GetMainWindow().ConfigControl;
        }

        private static ViewModel GetViewModel(FrameworkElement element)
        {
            return element.DataContext as ViewModel;
        }

        public static HomeControlViewModel GetHomeViewModel()
        {
            return GetViewModel(GetHomeControlView()) as HomeControlViewModel;
        }

        public static ConfigControlViewModel GetConfigViewModel()
        {
            return GetViewModel(GetConfigControlView()) as ConfigControlViewModel;
        }
    }
}