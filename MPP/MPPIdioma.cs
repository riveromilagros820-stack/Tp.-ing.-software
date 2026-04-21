using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BE;

namespace MPP
{
    public class MPPIdioma
    {
        private AccesoDal acceso = new AccesoDal();

        public List<BEIdioma> ListarIdiomas()
        {
            string query = "SELECT * FROM Idiomas";
            DataTable dt = acceso.Leer(query, null);

            List<BEIdioma> lista = new List<BEIdioma>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new BEIdioma
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Cultura = row["Cultura"].ToString()
                });
            }
            return lista;
        }

        public void CambiarIdiomaUsuario(int usuarioId, int idiomaId)
        {
            string query = "UPDATE Usuarios SET IdiomaId=@idioma WHERE Id=@id";
            var parametros = new List<SqlParameter> {
                new SqlParameter("@idioma", idiomaId),
                new SqlParameter("@id", usuarioId)
            };
            acceso.Escribir(query, parametros);
        }
    }
}
