using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ClinicAppointment
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> lazy = new Lazy<DatabaseConnection>(() => new DatabaseConnection());
        public static DatabaseConnection Instance { get { return lazy.Value; } }

        private string connectionString;

        private DatabaseConnection()
        {
            // Load the connection string from the configuration file
            connectionString = ConfigurationManager.ConnectionStrings["ClinicDbConnection"].ConnectionString;
        }

        // Return a new SqlConnection instance each time GetConnection is called
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
