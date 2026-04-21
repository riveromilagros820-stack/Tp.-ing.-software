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

        public void CrearUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuarios (Apellido, DNI, Contraseña, IdiomaId, Activo) VALUES (@a, @dni, @c, @i, @act)";
            var parametros = new List<SqlParameter> {
                new SqlParameter("@a", usuario.Apellido),
                new SqlParameter("@dni", usuario.DNI),
                new SqlParameter("@c", usuario.Contraseña),
                new SqlParameter("@i", usuario.IdiomaId),
                new SqlParameter("@act", usuario.Activo)
            };
            acceso.Escribir(query, parametros);
        }

        public Usuario ObtenerPorDNI(int dni)
        {
            string query = "SELECT * FROM Usuarios WHERE DNI=@dni";
            var parametros = new List<SqlParameter> {
                new SqlParameter("@dni", dni)
            };

            DataTable dt = acceso.Leer(query, parametros);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Usuario
            {
                Id = Convert.ToInt32(row["Id"]),
                Apellido = row["Apellido"].ToString(),
                DNI = Convert.ToInt32(row["DNI"]),                  
                Contraseña = row["Contraseña"].ToString(),
                IdiomaId = Convert.ToInt32(row["IdiomaId"]),
                Activo = Convert.ToBoolean(row["Activo"])
            };
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
