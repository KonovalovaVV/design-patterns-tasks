using Singleton.DataBase;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Singleton.DataBase
{
    internal class AppSettingsProvider
    {
        private static readonly Lazy<AppSettingsProvider> Instance =
            new Lazy<AppSettingsProvider>(() => new AppSettingsProvider());
        public readonly AppSettings Settings;
        private const string FileName = "AppSettings.json";
        private const string SectionName = "Settings";

        private AppSettingsProvider()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(FileName, optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            Settings = configuration.GetSection(SectionName).Get<AppSettings>();
        }

        public static AppSettingsProvider GetInstance()
        {
            return Instance.Value;
        }
    }
}
