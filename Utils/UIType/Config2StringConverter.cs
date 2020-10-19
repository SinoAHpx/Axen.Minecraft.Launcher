using System;
using System.Globalization;
using System.Windows.Data;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.Utils.UIType
{
    public class Config2StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as ConfigsListEntity)?.ConfigName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}