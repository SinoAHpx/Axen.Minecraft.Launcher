using System.ComponentModel;
using System.Windows;

namespace Axen.Minecraft.Launcher.Utils.UIType
{
    public class ViewModel : DependencyObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null && !string.IsNullOrWhiteSpace(propertyName))
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}