using System.Collections.ObjectModel;
using System.Windows.Input;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;
using Axen.Minecraft.Launcher.Utils.UIType;
using Axen.Minecraft.Launcher.Views.Home;
using MaterialDesignThemes.Wpf;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class HomeControlViewModel : ViewModel
    {
        public HomeControlViewModel()
        {
            OpenAccountManagerCommand = new DelegateCommand(OpenAccountManager);
        }

        public ObservableCollection<ConfigItemEntity> ConfigsList => ConfigModel.ConfigsList;

        public ICommand OpenAccountManagerCommand { get; set; }

        public void OpenAccountManager(object param)
        {
            DialogHost.Show(new AccountControlView());
        }
    }
}