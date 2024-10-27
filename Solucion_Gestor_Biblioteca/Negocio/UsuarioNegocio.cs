using Dapper;
using Modelo;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            using (IDbConnection dbConnection = DbConnection.GetConnection())
            {
                dbConnection.Open();

                string query = "SELECT ID, Nombre, Apellido, DNI, Telefono, Email, Imagen, Suspendido FROM Usuarios";
                return dbConnection.Query<Usuario>(query);
            }
        }

        public void InsertarUsuario(Usuario usuario)
        {
            using (IDbConnection dbConnection = DbConnection.GetConnection())
            {
                dbConnection.Open();

                string query = "INSERT INTO Usuarios (Nombre, Apellido, DNI, Telefono, Email, Imagen, Suspendido) VALUES (@Nombre, @Apellido, @DNI, @Telefono, @Email, @Imagen, @Suspendido)";
                dbConnection.Execute(query, usuario);
            }
        }
    }
}
