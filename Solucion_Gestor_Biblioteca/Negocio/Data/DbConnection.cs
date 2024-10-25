using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public static class DbConnection
    {
        public static IDbConnection GetConnection()
        {
            // Obtiene la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["BibliotecaDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}

