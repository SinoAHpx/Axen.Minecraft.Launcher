using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.Models
{
    public static class DownloadModel
    {
        public static ObservableCollection<DownloadItemEntity> MinecraftsList { get; set; }
    }
}