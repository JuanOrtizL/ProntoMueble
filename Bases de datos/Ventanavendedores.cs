using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bases_de_datos
{
    public partial class Ventanavendedores : Form
    {
        public Ventanavendedores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexión
                    conn.Open();

                    // 4. Crea el comando SQL con la consulta que omite la contraseña
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_vendedor, nombre, email FROM vendedor", conn))
                    {
                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al Label
                            foreach (DataRow row in dt.Rows)
                            {
                                label2.Text += $"ID: {row["id_vendedor"]}, Nombre: {row["nombre"]}, Email: {row["email"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar vendedores: " + ex.Message);
                }
            }
        }

        private void Ventanavendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
