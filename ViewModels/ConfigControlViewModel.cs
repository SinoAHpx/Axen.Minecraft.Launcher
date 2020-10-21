using System.Collections.ObjectModel;
using System.Windows.Input;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;
using Axen.Minecraft.Launcher.Utils.UIType;
using Axen.Minecraft.Launcher.Utils.UIUtils;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public partial class ConfigControlViewModel : ViewModel
    {
        public ConfigControlViewModel()
        {
            ConfigsList = new ObservableCollection<ConfigItemEntity>();

            var minecrafts = new ObservableCollection<string>
            {
                "aaaad1212dwadawd",
                "aaaaddawddwadawd",
                "aaaadzawddwadawd",
                "aaazaadzawddwadawd",
                "aaaaddwadawd",
                "aaaad1adwadawd",
                "aaaaawdddwadawd",
                "aaaawdddawdwadawd",
                "aaaad121dwadawd",
                "aaaazsddwadawd",
                "aaaaawdddwadawd",
                "aaaaddwadawd",
                "aaaaawdddwadawd",
                "aaaaddwadawd"
            };

            for (var i = 0; i < 10; i++)
                ConfigsList.Add(new ConfigItemEntity
                {
                    ConfigComment = $"备注注释{i}",
                    ConfigName = $"Config Name {i}",
                    MinecraftsList = minecrafts,
                    SelectedMinecraft = i
                });

            RegisterCommands();
        }

        public ObservableCollection<ConfigItemEntity> ConfigsList
        {
            get => ConfigModel.ConfigsList;
            set => ConfigModel.ConfigsList = value;
        }
    }

    //command area
    public partial class ConfigControlViewModel
    {
        public ICommand DeleteAllConfigCommand { get; set; }

        public void RegisterCommands()
        {
            DeleteAllConfigCommand = new DelegateCommand(DeleteAllConfig, null);
        }

        public async void DeleteAllConfig(object param)
        {
            var result = await ExMessageBox.ShowConfirm("警告", "此操作一旦执行，不可撤销，是否继续？", "执行", "取消");

            if (result) ConfigsList.Clear();
        }
    }
}