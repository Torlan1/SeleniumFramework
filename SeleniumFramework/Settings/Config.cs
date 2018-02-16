using System;
using System;
using System.Configuration;

namespace SeleniumFramework.Settings
{
    public class Config : IConfig
    {
        public string GetBaseUrl()
        {
            return ConfigurationManager.AppSettings["BaseUrl"];
        }
    }
}
