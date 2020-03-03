using System.Data.SqlClient;

namespace Singleton
{
    public class DataBase
    {
        private static DataBase Instance;
        private readonly string ConnectionString = @"Data Source=.\SQL EXPRESS;Initial Catalog=users db;Integrated Security=True";
        private readonly SqlConnection Connection;
 
        private DataBase()
        {
            Connection = new SqlConnection(ConnectionString);
            try
            {
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public static DataBase GetInstance()
        {
            return Instance ?? (DataBase.Instance = new DataBase());
        }

        public void CreateCommand(string queryString)
        {
            if (Instance != null)
            {
                SqlCommand command = new SqlCommand(queryString, Connection);
                command.ExecuteNonQuery();
            }
            else
            {
                throw new System.Exception("You are not connected to a database.");
            }
        }
    }

}