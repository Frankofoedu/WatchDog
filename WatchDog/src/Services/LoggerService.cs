﻿using WatchDog.src.Helpers;
using WatchDog.src.Interfaces;
using WatchDog.src.Models;

namespace WatchDog.src.Services
{
    public class LoggerService : ILoggerService
    {
        public void ClearWatchLogs()
        {
            if (AutoClearModel.IsAutoClear)
            {
                LiteDBHelper.ClearWatchLog();
                LiteDBHelper.ClearWatchExceptionLog();
            }

        }
    }
}
