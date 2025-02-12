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
    public partial class Iniciosesion : Form
    {


        string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=1590;";
        public Iniciosesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                label3.Text = "Por favor ingrese usuario y contraseña.";
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT 1 FROM  vendedor WHERE email = @email AND password = @contraseña"; // Ajusta la tabla y las columnas según tu base de datos

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Inicio de sesión exitoso
                                this.Hide(); // O this.Close(); para cerrar el formulario de inicio de sesión
                                Principal principal = new Principal(); // Reemplaza Principal con el nombre de tu formulario principal
                                principal.Show();
                            }
                            else
                            {
                                label3.Text = "Usuario o contraseña incorrectos.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Error al iniciar sesión: " + ex.Message;
            }
        }


    }
    }

