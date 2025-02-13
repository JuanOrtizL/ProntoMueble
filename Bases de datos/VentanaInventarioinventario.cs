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
    public partial class VentanaInventarioinventario : Form
    {
        public VentanaInventarioinventario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventanainventario ventanainventario = new Ventanainventario();
            ventanainventario.Show();
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

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "mueble"
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT m.id_mueble , m.alto_dimensiones, m.ancho_dimensiones, m.largo_dimensiones, m.precio, m.stock,p.id_proveedor,  c.nombre AS nombre_color,   ma.nombre AS nombre_material,   t.nombre AS nombre_tipo FROM mueble m join color c on (m.id_color = c.id_color) join tipo t on (m.id_tipo = t.id_tipo) join material ma on (m.id_material = ma.id_material) join proveedor p on (m.id_proveedor = p.id_proveedor)", conn))
                    {

                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al RichTextBox
                            foreach (DataRow row in dt.Rows)
                            {
                                richTextBox1.Text += $"ID: {row["id_mueble"]}, Alto: {row["alto_dimensiones"]}, Ancho: {row["ancho_dimensiones"]}, Largo: {row["largo_dimensiones"]}, Precio: {row["precio"]}, Stock: {row["stock"]},  Color: {row["nombre_color"]},  Material: {row["nombre_material"]},  Tipo: {row["nombre_tipo"]}, ID Proveedor: {row["id_proveedor"]}\n\n\n\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar muebles: " + ex.Message);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
