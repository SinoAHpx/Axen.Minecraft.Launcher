﻿using System.Collections.ObjectModel;
using Axen.Minecraft.Launcher.Utils.DataType;

namespace Axen.Minecraft.Launcher.Models
{
    public static class ConfigModel
    {
        public static ObservableCollection<ConfigItemEntity> ConfigsList { get; set; }
    }
}