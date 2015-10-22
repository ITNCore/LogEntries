using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure;

namespace LogentriesCore
{
    internal static class Configuration
    {
        /// <summary>
        /// Retrieve configuration settings.  Checks the Environment variable as the last fallback.
        /// </summary>
        /// <param name="settingName"></param>
        /// <returns></returns>
        public static string GetSettingValue(string settingName)
        {
            string cloudconfig = null;
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                cloudconfig = ConfigurationManager.AppSettings.Get(settingName);
            }
            else
            {
                cloudconfig = CloudConfigurationManager.GetSetting(settingName);
            }

            if (!String.IsNullOrWhiteSpace(cloudconfig))
            {
                return cloudconfig;
            }

            var appconfig = ConfigurationManager.AppSettings[settingName];
            if (!String.IsNullOrWhiteSpace(appconfig))
            {
                return appconfig;
            }

            var envconfig = Environment.GetEnvironmentVariable(settingName);
            if (!String.IsNullOrWhiteSpace(envconfig))
            {
                return envconfig;
            }

            return null;
        }
    }
}
