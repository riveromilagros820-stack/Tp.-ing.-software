using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPBitacora
    {
        private AccesoDal acceso = new AccesoDal();

        public void Registrar(int usuarioId, string evento, string descripcion)
        {
            string query = "INSERT INTO Bitacora (UsuarioId, FechaHora, Evento, Descripcion) VALUES (@u, GETDATE(), @e, @d)";

            var parametros = new List<SqlParameter> {
                new SqlParameter("@u", usuarioId),
                new SqlParameter("@e", evento),
                new SqlParameter("@d", descripcion)
            };

            acceso.Escribir(query, parametros);
        }
    }
}
