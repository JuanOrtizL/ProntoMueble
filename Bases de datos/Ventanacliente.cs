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
    public partial class Ventanacliente : Form
    {
        public Ventanacliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventanainventario ventanaInventario = new Ventanainventario();
            Principal Principal = new Principal();
            this.Hide();
            Principal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

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
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select c.id_cliente, c.nombre , c.direccion, c.email , c.fecha_registro, tc.telefono from cliente c join telefono_cliente tc on (c.id_cliente = tc.id_cliente) where c.id_cliente = @id_cliente or  c.nombre = @nombre;", conn))
                    {
                        // 6. Asigna el valor del parámetro
                        cmd.Parameters.AddWithValue("@id_cliente", idcliente);
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
                                richTextBox1.Text += $"  ID  Cliente: {row["id_cliente"]},    Nombre: {row["nombre"]},    Direccion: {row["direccion"]},  Fecha:   {row["fecha_registro"]},  Email:   {row["email"]},  Telefono:   {row["telefono"]}\n";
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

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaclientesagregar ventanaclientesagregar = new ventanaclientesagregar();
            ventanaclientesagregar.Show();
            this.Hide();
        }

        private void Ventanacliente_Load(object sender, EventArgs e)
        {

        }
    }
}
