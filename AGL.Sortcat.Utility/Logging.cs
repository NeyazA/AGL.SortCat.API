using NLog;
using System;

namespace AGL.Sortcat.Utility
{
    public class Logging
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void LogError(string message)
        {
            logger.Error(message);
        }
        public static void HandleException(Exception exception)
        {
            logger.Error(exception.InnerException + ":-" + exception.StackTrace);
        }
        public static void Log(string message)
        {
            logger.Info(message);
        }
    }
}
