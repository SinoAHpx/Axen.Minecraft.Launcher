using System.Windows.Input;

namespace Axen.Minecraft.Launcher.Utils.DataType
{
    public class CarouselItemEntity
    {
        public string Image { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string ActionTitle { get; set; }
        public ICommand ActionHandler { get; set; }
    }
}