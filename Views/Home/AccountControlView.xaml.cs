using System.Windows.Controls;
using Axen.Minecraft.Launcher.ViewModels;

namespace Axen.Minecraft.Launcher.Views.Home
{
    /// <summary>
    ///     AccountControlView.xaml 的交互逻辑
    /// </summary>
    public partial class AccountControlView : UserControl
    {
        public AccountControlView()
        {
            InitializeComponent();

            DataContext = new AccountControlViewModel();
        }
    }
}