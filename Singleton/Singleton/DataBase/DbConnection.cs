using System;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Singleton.DataBase
{
    class DbConnection
    {
        private static readonly Lazy<DbConnection> Instance = 
            new Lazy<DbConnection>(() => new DbConnection(_tempFileName, _tempSectionName) );
        private readonly string _fileName;
        private readonly string _sectionName;
        private static string _tempFileName;
        private static string _tempSectionName;
        public readonly SqlConnection Connection;

        private DbConnection(string fileName, string sectionName)
        {
            _fileName = fileName;
            _sectionName = sectionName;
            Connection = new SqlConnection(Connect().ConnectionString); 
            try
            {
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        private AppSettings Connect()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_fileName, optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var settings = configuration.GetSection(_sectionName).Get<AppSettings>();
            return settings;
        }

        public static DbConnection GetInstance(string fileName, string sectionName)
        {
            _tempFileName = fileName;
            _tempSectionName = sectionName;
            return Instance.Value;
        }
        
    }
}
