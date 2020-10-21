using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.Models
{
    public static class AccountModel
    {
        public static ObservableCollection<AccountItemEntity> AccountsList { get; set; }
    }
}