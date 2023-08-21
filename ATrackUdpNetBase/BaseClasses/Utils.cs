using System;
namespace ATrackUdpNetBase
{
    public static class Utils
    {
        private static readonly log4net.ILog log_data = log4net.LogManager.GetLogger("ATrackUdpNetListenerData");
        private static readonly log4net.ILog log_data2 =log4net.LogManager.GetLogger("ATrackUdpNetListenerMessage");
        public static string LogUniqueId;
        public static void LogData(string data)
        {
            try
            {
                log_data.Info($"{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ffff tt ")} | {data}");
            }
            catch (Exception ex)
            {
                log_data2.Info($"{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ffff tt ")} | Exception LogData(): " + ex.Message);
            }
        }


        public static void LogMessage(string message)
        {
            try
            {
                log_data2.Info($"{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ffff tt ")} | {message}");
            }
            catch (Exception ex)
            {

                log_data2.Info($"{DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ffff tt ")} | Exception: LogMessage() | {ex.Message}");
            }
        }
    }
}
