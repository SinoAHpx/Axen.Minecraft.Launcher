using System.Windows;

namespace Axen.Minecraft.Launcher.Utils.UIUtils
{
    public class StyleLocator
    {
        public static Style GetStyle(string styleName)
        {
            return Application.Current.FindResource(styleName) as Style;
        }
    }
}