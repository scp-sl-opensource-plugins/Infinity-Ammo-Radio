﻿using Exiled.API.Interfaces;

namespace InfinityAmmo_Radio
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public bool InfinityAmmoIsEnabled { get; set; } = true;
        public bool InfinityRadioIsEnabled { get; set; } = true;
    }
}