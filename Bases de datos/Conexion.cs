using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Bases_de_datos
{
    internal class Conexion
    {
        public class ClaseConexion
        {
            private string connectionString = "Server=localhost;Port=5432;Database=nombre_de_tu_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;";

            public NpgsqlConnection ObtenerConexion()
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }

            


        }
    }
}
