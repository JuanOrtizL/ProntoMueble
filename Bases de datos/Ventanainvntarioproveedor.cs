using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bases_de_datos
{
    public partial class Ventanainvntarioproveedor : Form
    {
        public Ventanainvntarioproveedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventanainventario ventanainventario = new Ventanainventario();
            ventanainventario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int idcliente);

            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 4. Abre la conexión
                    conn.Open();

                    // 5. Crea el comando SQL con parámetros
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select p.id_proveedor, p.nombre , p.persona_contacto, p.direccion, tp.telefono from proveedor p join telefono_proveedor tp on (p.id_proveedor = tp.id_proveedor) where p.id_proveedor = @id_proveedor  or  p.nombre = @nombre;", conn))
                    {
                        // 6. Asigna el valor del parámetro
                        cmd.Parameters.AddWithValue("@id_proveedor", idcliente);
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);

                        // 7. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 8. Muestra los resultados en el RichTextBox
                            richTextBox1.Clear(); // Limpia el RichTextBox antes de mostrar nuevos resultados
                            foreach (DataRow row in dt.Rows)
                            {
                                richTextBox1.Text += $"  ID  Proveedor: {row["id_proveedor"]},    Nombre: {row["nombre"]},    Direccion: {row["direccion"]},  Persona de contacto:   {row["persona_contacto"]},  Telefono:   {row["telefono"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 9. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al buscar el proveedor: " + ex.Message);
                }
            }
        }
    }
}
