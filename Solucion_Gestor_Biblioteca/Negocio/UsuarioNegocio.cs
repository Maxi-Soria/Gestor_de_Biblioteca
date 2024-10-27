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

        //Validar si existe el dni en la base de datos
        public bool ExisteDNI(string dni)
        {
            using (IDbConnection dbConnection = DbConnection.GetConnection())
            {
                dbConnection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE DNI = @DNI";
                return dbConnection.ExecuteScalar<int>(query, new { DNI = dni }) > 0;
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (IDbConnection dbConnection = DbConnection.GetConnection())
            {
                dbConnection.Open();

                string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Telefono = @Telefono, Email = @Email, Imagen = @Imagen, Suspendido = @Suspendido WHERE ID = @ID";
                dbConnection.Execute(query, usuario);
            }
        }

        public void EliminarUsuario(int id)
        {
            using (IDbConnection dbConnection = DbConnection.GetConnection())
            {
                dbConnection.Open();

                string query = "DELETE FROM Usuarios WHERE ID = @ID";
                dbConnection.Execute(query, new { ID = id });
            }
        }

    }
}
