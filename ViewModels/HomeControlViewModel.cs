using System.Windows;
using System.Windows.Input;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class HomeControlViewModel : ViewModel
    {
        public HomeControlViewModel()
        {
            TestCommand = new DelegateCommand(ShowTest, null);
        }

        public ICommand TestCommand { get; }

        private void ShowTest(object o)
        {
            MessageBox.Show(o.ToString());
        }
    }
}