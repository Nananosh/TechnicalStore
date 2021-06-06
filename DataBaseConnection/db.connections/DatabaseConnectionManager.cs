using System.Data.SQLite;

namespace TechnicalStore.DataBaseConnection.db.connections
{
    public static class DatabaseConnectionManager
    {
        private static string GetConnectionString()
        {
            return
                @"Data Source=C:\Users\nanan\Desktop\TechnicalStore\DataBaseConnection\TechnicalStore.sqlite";
        }

        public static SQLiteConnection GetSqlConnection()
        {
            return new(GetConnectionString(), true);
        }
    }
}