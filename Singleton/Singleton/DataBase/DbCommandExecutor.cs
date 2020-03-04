using System.Data.SqlClient;

namespace Singleton.DataBase
{
    class DbCommandExecutor
    {
        private readonly DbConnection _dataBase;

        public DbCommandExecutor(DbConnection db)
        {
            _dataBase = db;
        }

        public void CreateCommand(string queryString)
        {
            try
            {
                SqlCommand command = new SqlCommand(queryString, _dataBase.Connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
