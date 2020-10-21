using System.Windows.Controls;
using Axen.Minecraft.Launcher.ViewModels;

namespace Axen.Minecraft.Launcher.Views.Download
{
    /// <summary>
    ///     DownloadControlView.xaml 的交互逻辑
    /// </summary>
    public partial class DownloadControlView : UserControl
    {
        public DownloadControlView()
        {
            InitializeComponent();

            DataContext = new DownloadControlViewModel();
        }
    }
}