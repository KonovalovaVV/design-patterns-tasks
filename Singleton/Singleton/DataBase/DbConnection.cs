﻿using System;
using System.Data.SqlClient;
using Singleton.AppSettings;

namespace Singleton.DataBase
{
    internal class DbConnection
    {
        private static readonly Lazy<DbConnection> Instance = 
            new Lazy<DbConnection>(() => new DbConnection() );
        public readonly SqlConnection Connection;

        private DbConnection()
        {
            Connection = new SqlConnection(AppSettingsProvider.GetInstance().Settings.ConnectionString); 
            try
            {
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DbConnection GetInstance()
        {
            return Instance.Value;
        }
    }
}
