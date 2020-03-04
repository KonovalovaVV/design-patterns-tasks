using System;
using System.Data.SqlClient;

namespace Singleton.DataBase
{
    internal class DbConnection
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
            Connection = new SqlConnection(new AppSettings(fileName, sectionName).ConnectionString); 
            try
            {
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DbConnection GetInstance(string fileName, string sectionName)
        {
            _tempFileName = fileName;
            _tempSectionName = sectionName;
            return Instance.Value;
        }
        
    }
}
