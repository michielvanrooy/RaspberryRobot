﻿using System;
using System.IO;

namespace Logger
{
    public static class Logger
    {
        public static void LogError(Exception ex)
        {
            //TODO: Fix this is not working on Raspberry
            File.WriteAllText("/home/pi/temp/logs/log.txt", $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} : {ex.ToString()}");
        }
    }
}
