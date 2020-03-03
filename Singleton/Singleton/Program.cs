namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataBase dataBase = DataBase.GetInstance();
                dataBase.CreateCommand("INSERT INTO Users (Name, Age) VALUES ('Tom', 18)");
            }
            catch (System.Exception ex)
            {
                System.Console.Write(ex);
            }
        }
    }
}