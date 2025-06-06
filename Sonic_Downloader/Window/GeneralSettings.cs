﻿using System;

namespace Sonic_Downloader.Window
{
    public  class GeneralSettings
    {
        public  int MaxConnection { get; set; } = 8;
        public  int Timeout { get; set; } = 60*1000*5;

        public string StoragePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Downloads\\Sonic Downloads";

    }
}
