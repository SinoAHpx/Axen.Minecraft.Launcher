using System.Windows.Controls;
using Axen.Minecraft.Launcher.ViewModels;

namespace Axen.Minecraft.Launcher.Views.Config
{
    /// <summary>
    ///     ConfigControlView.xaml 的交互逻辑
    /// </summary>
    public partial class ConfigControlView : UserControl
    {
        public ConfigControlView()
        {
            InitializeComponent();
            DataContext = new ConfigControlViewModel();
        }
    }
}