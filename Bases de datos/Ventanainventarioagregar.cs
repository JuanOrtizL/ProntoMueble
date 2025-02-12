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
    public partial class Ventanainventarioagregar : Form
    {
        public Ventanainventarioagregar()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventanainventario ventanainventario = new Ventanainventario();
            ventanainventario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Obtén los valores de los controles de tu formulario
            int alto = int.Parse(textBox1.Text);
            int ancho = int.Parse(textBox2.Text);
            int largo = int.Parse(textBox3.Text);
            int precio = int.Parse(textBox4.Text);
            int stock = int.Parse(textBox7.Text);
            int idColor = int.Parse(textBox10.Text);
            int idMaterial = int.Parse(textBox9.Text);
            int idTipo = int.Parse(textBox11.Text);
            long idProveedor = long.Parse(textBox8.Text);

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
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO mueble (alto_dimensiones, ancho_dimensiones, largo_dimensiones, precio, stock, id_color, id_material, id_tipo, id_proveedor) VALUES (@alto, @ancho, @largo, @precio, @stock, @idColor, @idMaterial, @idTipo, @idProveedor)", conn))
                    {
                        // 6. Asigna los valores a los parámetros
                        cmd.Parameters.AddWithValue("@alto", alto);
                        cmd.Parameters.AddWithValue("@ancho", ancho);
                        cmd.Parameters.AddWithValue("@largo", largo);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@idColor", idColor);
                        cmd.Parameters.AddWithValue("@idMaterial", idMaterial);
                        cmd.Parameters.AddWithValue("@idTipo", idTipo);
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                        // 7. Ejecuta el comando SQL
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // 8. Muestra un mensaje de éxito
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Mueble agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el mueble.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 9. Muestra un mensaje de error
                    MessageBox.Show("Error al agregar el mueble: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexión
                    conn.Open();

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "color"
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM color", conn))
                    {
                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al Label
                            foreach (DataRow row in dt.Rows)
                            {
                                label4.Text += $"ID: {row["id_color"]},   color: {row["nombre"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar colores: " + ex.Message);
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexión
                    conn.Open();

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "color"
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM tipo", conn))
                    {
                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al Label
                            foreach (DataRow row in dt.Rows)
                            {
                                label2.Text += $"ID: {row["id_tipo"]},    tipo: {row["nombre"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar colores: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexión
                    conn.Open();

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "color"
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM material", conn))
                    {
                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al Label
                            foreach (DataRow row in dt.Rows)
                            {
                                label3.Text += $"ID: {row["id_material"]},    material: {row["nombre"]}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar colores: " + ex.Message);
                }
            }
        }
    }
}
