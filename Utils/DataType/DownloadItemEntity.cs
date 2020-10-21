using System.Windows.Input;

namespace Axen.Minecraft.Launcher.Utils.DataType
{
    public class DownloadItemEntity
    {
        public string Version { get; set; }
        public string VersionType { get; set; }
        public string ReleaseDate { get; set; }
        public string BasedOn { get; set; }
        public ICommand Command { get; set; }
        public object CommandParameter { get; set; }
    }
}