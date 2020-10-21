using System.Collections.ObjectModel;

namespace Axen.Minecraft.Launcher.Utils.DataType
{
    public class ConfigItemEntity
    {
        public string ConfigName { get; set; }
        public int SelectedMinecraft { get; set; }
        public ObservableCollection<string> MinecraftsList { get; set; }
        public string ConfigComment { get; set; }
    }
}