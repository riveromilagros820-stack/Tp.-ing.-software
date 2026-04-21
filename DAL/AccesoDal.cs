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
            // 🔗 Cadena de conexión: ajustala según tu servidor y base de datos
            private string connectionString = "Data Source=DESKTOP-UOCRKUM;Initial Catalog=Proyecto_BD;Integrated Security=True";

            /// <summary>
            /// Ejecuta consultas que devuelven datos (SELECT)
            /// </summary>
            public DataTable Leer(string query, List<SqlParameter> parametros)
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlCommand comando = new SqlCommand(query, conexion);
                    if (parametros != null) comando.Parameters.AddRange(parametros.ToArray());

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }

            /// <summary>
            /// Ejecuta consultas que no devuelven datos (INSERT, UPDATE, DELETE)
            /// </summary>
            public void Escribir(string query, List<SqlParameter> parametros)
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    if (parametros != null) comando.Parameters.AddRange(parametros.ToArray());
                    comando.ExecuteNonQuery();
                }
            }
        }
    }

