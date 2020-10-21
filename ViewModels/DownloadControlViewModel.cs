using System;
using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;
using Axen.Minecraft.Launcher.Utils.UIType;
using Axen.Minecraft.Launcher.Utils.UIUtils;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class DownloadControlViewModel
    {
        public DownloadControlViewModel()
        {
            MinecraftsList = new ObservableCollection<DownloadItemEntity>();

            for (var i = 0; i < 20; i++)
                MinecraftsList.Add(new DownloadItemEntity
                {
                    BasedOn = $"1.{i}",
                    ReleaseDate = DateTime.Now.ToString(),
                    Version = "1.8.9",
                    VersionType = "Vanilla",
                    Command = new DelegateCommand(Download, null),
                    CommandParameter = $"1.{i}"
                });
        }

        public ObservableCollection<DownloadItemEntity> MinecraftsList
        {
            get => DownloadModel.MinecraftsList;
            set => DownloadModel.MinecraftsList = value;
        }

        public async void Download(object param)
        {
            await ExMessageBox.ShowAlert("Test", param.ToString(), "Confirm");
        }
    }
}