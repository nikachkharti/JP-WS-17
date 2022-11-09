using Todo.Services.Interfaces;
using TodoApp.Library;

namespace Todo.Services
{
    public static class GlobalConfig
    {
        public static string ConnectionString()
        {
            return @"Server=DESKTOP-ILO1R6I\SQLEXPRESS;Database=JpWs17Todo;Trusted_Connection=True;TrustServerCertificate=true";
        }


        public static IDataConnection? ConnectionType { get; private set; }
        public static IDataConnection ChooseDataType(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.Sql:
                    ConnectionType = new SqlDataConnector();
                    break;
            }

#pragma warning disable CS8603 // Possible null reference return.
            return ConnectionType;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
