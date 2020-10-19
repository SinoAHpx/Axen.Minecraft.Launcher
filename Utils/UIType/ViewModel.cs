using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Axen.Minecraft.Launcher.Utils.UIType
{
    public class ViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null && !string.IsNullOrWhiteSpace(propertyName))
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}