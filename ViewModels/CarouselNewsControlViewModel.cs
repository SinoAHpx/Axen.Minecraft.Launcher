using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;
using Axen.Minecraft.Launcher.Utils.UIType;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class CarouselNewsControlViewModel : ViewModel
    {
        public CarouselNewsControlViewModel()
        {
            CarouselItems = new ObservableCollection<CarouselItemEntity>();

            for (var i = 0; i < 10; i++)
                CarouselItems.Add(new CarouselItemEntity
                {
                    ActionHandler = null,
                    ActionTitle = "GO",
                    Image = @"C:\Users\ahpx\Downloads\1108260.jpg",
                    Link = "aw",
                    Title = "aidghjasewdg jkhagsef jhajshedkfb jlahsehfljhbasdfkbn"
                });
        }

        public ObservableCollection<CarouselItemEntity> CarouselItems
        {
            get => CarouselModel.CarouselItems;
            set => CarouselModel.CarouselItems = value;
        }
    }
}