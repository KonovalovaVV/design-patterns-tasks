﻿using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Singleton.AppSettings
{
    internal class AppSettingsProvider
    {
        public readonly AppSettings Settings;
        private const string FileName = "AppSettings.json";
        private const string SectionName = "Settings";
        private static readonly Lazy<AppSettingsProvider> Instance =
            new Lazy<AppSettingsProvider>(() => new AppSettingsProvider());

        private AppSettingsProvider()
        {
            Settings = GetSettings();
        }

        private AppSettings GetSettings()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(FileName, optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            return configuration.GetSection(SectionName).Get<AppSettings>();
        }

        public static AppSettingsProvider GetInstance()
        {
            return Instance.Value;
        }
    }
}
