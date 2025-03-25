using log4net;
using log4net.Config;

namespace ImageReview.Logic
{
    public static class LogFile
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogFile));
        public static void UpdateLogFile(string Msg)
        {
            XmlConfigurator.Configure();
            log.Info(Msg);
        }
    }
}
