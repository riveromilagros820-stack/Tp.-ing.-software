using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoDal
    {
        private string connectionString = "";

        public DataTable Leer(string query, List<SqlParameter> parametros)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parametros != null) cmd.Parameters.AddRange(parametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Escribir(string query, List<SqlParameter> parametros)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parametros != null) cmd.Parameters.AddRange(parametros.ToArray());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
