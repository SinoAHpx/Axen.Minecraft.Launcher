using System;
using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Models;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.ViewModels
{
    public class AccountControlViewModel
    {
        public AccountControlViewModel()
        {
            AccountsList = new ObservableCollection<AccountItemEntity>();
            for (var i = 0; i < 20; i++)
                AccountsList.Add(new AccountItemEntity
                {
                    AccessToken = "awd",
                    Avatar = @"C:\Users\ahpx\Downloads\pexels-craig-adderley-1563355.jpg",
                    Name = $"{i}alkjhgsdnijknawjd",
                    Uuid = Guid.NewGuid().ToString("N")
                });
        }

        public ObservableCollection<AccountItemEntity> AccountsList
        {
            get => AccountModel.AccountsList;
            set => AccountModel.AccountsList = value;
        }
    }
}