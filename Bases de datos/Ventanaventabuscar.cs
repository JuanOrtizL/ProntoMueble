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
    public partial class Ventanaventabuscar : Form
    {
        public Ventanaventabuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanaventa Ventanaventa = new Ventanaventa(); // Crea una instancia del formulario de venta
            this.Hide();
            Ventanaventa.Show(); // Abre el formulario de venta
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Obtén el ID de venta del cuadro de texto
            if (!int.TryParse(textBox2.Text, out int idVenta))
            {
                MessageBox.Show("Ingrese un ID de venta válido.");
                return;
            }

            // 2. Define la cadena de conexión
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 3. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 4. Abre la conexión
                    conn.Open();

                    // 5. Crea el comando SQL con parámetros
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT v.id_venta, v.id_cliente, v.id_vendedor, v.fecha, mv.id_mueble, mv.cantidad, v.total FROM venta v INNER JOIN mueble_venta mv ON v.id_venta = mv.id_venta WHERE v.id_venta = @id_venta", conn))
                    {
                        // 6. Asigna el valor del parámetro
                        cmd.Parameters.AddWithValue("@id_venta", idVenta);

                        // 7. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 8. Muestra los resultados en el RichTextBox
                            richTextBox1.Clear(); // Limpia el RichTextBox antes de mostrar nuevos resultados
                            foreach (DataRow row in dt.Rows)
                            {
                                richTextBox1.Text += $"ID  Venta: {row["id_venta"]},  ID Cliente: {row["id_cliente"]},  ID Vendedor: {row["id_vendedor"]},  Fecha: {row["fecha"]},  ID Mueble: {row["id_mueble"]},  Cantidad: {row["cantidad"]},  Total: {row["total"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 9. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al buscar venta: " + ex.Message);
                }
            }
        }
    }
}
