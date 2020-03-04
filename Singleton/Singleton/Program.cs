using Singleton.DataBase;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DbConnection dataBase = DbConnection.GetInstance("AppSettings.json", "Settings");
                DbCommandExecutor commandExecutor = new DbCommandExecutor(dataBase);
                commandExecutor.ExecuteCommand("INSERT INTO Users (Name, Age) VALUES ('Tom', 18)");
            }
            catch (System.Exception ex)
            {
                System.Console.Write(ex);
            }
        }
    }
}