using System.Configuration;

namespace SavvyTime.Configuration
{
    public class Config
    {
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetEnvironment()
        {
            return GetConfigValue("Environment");
        }

        public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }

        public static string GetURL(string applicationName)
        {
            return GetConfigValue($"{applicationName}.{GetEnvironment()}");
        }
    }
}
