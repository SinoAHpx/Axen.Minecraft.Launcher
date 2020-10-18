using System.Windows.Controls;
using Axen.Minecraft.Launcher.ViewModels;

namespace Axen.Minecraft.Launcher.Views
{
    /// <summary>
    ///     HomeControlView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeControlView : UserControl
    {
        public HomeControlView()
        {
            InitializeComponent();

            DataContext = new HomeControlViewModel();
        }
    }
}