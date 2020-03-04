using System.IO;
using Microsoft.Extensions.Configuration;

namespace Singleton.DataBase
{
    internal class AppSettings
    {
        private readonly string _fileName;
        private readonly string _sectionName;

        public string ConnectionString { get; set; }

        public AppSettings(string fileName, string sectionName)
        {
            _fileName = fileName;
            _sectionName = sectionName;
            Connect();
        }

        public void Connect()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_fileName, optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var settings = configuration.GetSection(_sectionName).Get<AppSettings>();
            ConnectionString = settings._sectionName;
        }
    }
}
