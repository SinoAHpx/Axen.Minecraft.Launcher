using System.Windows.Controls;
using Axen.Minecraft.Launcher.ViewModels;

namespace Axen.Minecraft.Launcher.Views.Download
{
    /// <summary>
    ///     CarouselNewsControlView.xaml 的交互逻辑
    /// </summary>
    public partial class CarouselNewsControlView : UserControl
    {
        public CarouselNewsControlView()
        {
            InitializeComponent();

            DataContext = new CarouselNewsControlViewModel();
        }
    }
}