using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Utils.UIType;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class HomeControlViewModel : ViewModel
    {
        public HomeControlViewModel()
        {
            ConfigsList = new ObservableCollection<string>();
            for (var i = 0; i < 20; i++) ConfigsList.Add($"TESTTTTTA:{i}");
        }

        public ObservableCollection<string> ConfigsList { get; set; }
    }
}