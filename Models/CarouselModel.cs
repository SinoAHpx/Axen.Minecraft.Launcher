using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.Models
{
    public static class CarouselModel
    {
        public static ObservableCollection<CarouselItemEntity> CarouselItems { get; set; }
    }
}