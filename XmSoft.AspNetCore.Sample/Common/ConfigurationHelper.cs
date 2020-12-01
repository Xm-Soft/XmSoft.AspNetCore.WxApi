using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.Sample.Common
{
    public class ConfigurationHelper
    {
        public static IConfiguration Config { get; set; }
        public static void InitConfigurationHelper(IConfiguration _Config) => Config = _Config;
        public static string GetSection(string key)
        {
            return Config.GetSection(key).Value;
        }
        public static T GetSection<T>(string key)
        {
            return Config.GetSection(key).Get<T>();
        }
        public static T GetAppSettings<T>(string key) where T : class, new()
        {
            var appconfig = new ServiceCollection()
            .AddOptions()
            .Configure<T>(Action => { Config.GetSection(key); })
            .BuildServiceProvider()
            .GetService<IOptions<T>>()
            .Value;
            return appconfig;
        }
    }
}
