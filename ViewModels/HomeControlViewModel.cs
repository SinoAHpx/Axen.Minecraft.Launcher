using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;
using Axen.Minecraft.Launcher.Utils.UIType;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class HomeControlViewModel : ViewModel
    {
        public ObservableCollection<ConfigsListEntity> ConfigsList => ConfigModel.ConfigsList;
    }
}