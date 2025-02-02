using Microsoft.Extensions.Configuration;
using NLog.Extensions.Logging;
using NLog;

namespace Common.Helpers
{
    public class LogHelper
    {
        public static void InitializeLogging(string configFilePath)
        {
            var config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile(configFilePath, optional: false, reloadOnChange: false)
           .Build();

            LogManager.Configuration = new NLogLoggingConfiguration(config.GetSection("NLog"));
        }
    }
}
