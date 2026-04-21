using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPUsuario
    {
        private AccesoDal acceso = new AccesoDal();

        public Usuario ObtenerPorDNI(string dni)
        {
            string query = "SELECT * FROM Usuarios WHERE DNI=@dni";

            // parámetros para evitar SQL Injection
            var parametros = new List<SqlParameter> {
                new SqlParameter("@dni", dni)
            };

            // ejecutar la consulta y obtener resultados en un DataTable
            DataTable dt = acceso.Leer(query, parametros);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            Usuario usuario = new Usuario
            {
               Id = Convert.ToInt32(row["Id"]),
               Apellido = row["Apellido"].ToString(),
                DNI = Convert.ToInt32(row["DNI"]),
                Contraseña = row["Contraseña"].ToString(),
               IdiomaId = Convert.ToInt32(row["IdiomaId"]),
               Activo = Convert.ToBoolean(row["Activo"])
            };

            return usuario;
        }

        public void CambiarContraseña(int usuarioId, string nuevaContraseña)
        {
            string query = "UPDATE Usuarios SET Contraseña=@pass WHERE Id=@id";
            var parametros = new List<SqlParameter> {
                new SqlParameter("@pass", nuevaContraseña),
                new SqlParameter("@id", usuarioId)
            };

            acceso.Escribir(query, parametros);
        }

    }
}
