﻿// Copyright (c) Arctium.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Arctium.Core.Logging
{
    public class Log
    {
        static Logger logger;

        public static void Start(LogTypes logTypes, LogFile logFile = null)
        {
            logger = logger ?? new Logger { LogTypes = logTypes };

            logger?.Start(logFile);
        }

        public static void Stop()
        {
            logger?.Stop();

            logger = null;
        }

        public static void Resume(LogTypes logTypes) => logger.LogTypes = logTypes;
        public static void Pause() => logger.LogTypes = LogTypes.None;

        public static void ResumeConsoleOut() => logger.ShowConsoleOut = true;
        public static void PauseConsoleOut() => logger.ShowConsoleOut = false;

        public static void Message(LogTypes logType, string text, bool newLine = true) => logger.Message(logType, text, newLine);

        public static void NewLine() => logger.NewLine();

        public static void WaitForKey() => logger.WaitForKey();

        public static void Clear() => logger.Clear();
    }
}
