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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bases_de_datos
{
    public partial class ventanaclientesagregar : Form
    {
        public ventanaclientesagregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanacliente ventanacliente = new Ventanacliente();
            ventanacliente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Obtener datos del formulario
            string nombre = textBox1.Text;
            string direccion = textBox2.Text;
            string email = textBox4.Text;
            DateTime fechaRegistro = DateTime.Parse(dateTimePicker1.Text);
            string telefono = textBox3.Text;

            // 2. Insertar cliente y obtener ID
            int idCliente = InsertarCliente(nombre, direccion, email, fechaRegistro);

            if (idCliente > 0)
            {
                // 3. Insertar teléfono
                if (InsertarTelefono(idCliente, telefono))
                {
                    MessageBox.Show("Cliente y teléfono agregados correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el teléfono.");
                }
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente.");
            }
        }

        private int InsertarCliente(string nombre, string direccion, string email, DateTime fechaRegistro)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO cliente (nombre, direccion, email, fecha_registro) VALUES (@nombre, @direccion, @email, @fecha_registro) RETURNING id_cliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@fecha_registro", fechaRegistro);

                        // Ejecutar consulta y obtener ID generado
                        return (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cliente: " + ex.Message);
                    return -1;
                }
            }
        }

        private bool InsertarTelefono(int idCliente, string telefono)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO telefono_cliente (id_cliente, telefono) VALUES (@id_cliente, @telefono)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("@telefono", telefono);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar teléfono: " + ex.Message);
                    return false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

