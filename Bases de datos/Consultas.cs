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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Obtener la opción seleccionada del ComboBox
            string opcionSeleccionada = comboBox1.SelectedItem.ToString();

            // 2. Definir la consulta SQL
            string consultaSQL = "";

            // 3. Condiciones para asignar la consulta SQL según la opción seleccionada
            if (opcionSeleccionada == "Cliente que gasto mas en un mes")
            {
                consultaSQL = "SELECT * FROM mayor_comprador;";
            }
            else if (opcionSeleccionada == "Clientes nuevos (cada mes)")
            {
                consultaSQL = "SELECT * FROM nuevos_clientes;";
            }
            else if (opcionSeleccionada == "Cual vendedor realizo más ventas durante el ultimo mes")
            {
                consultaSQL = "SELECT * FROM mr_ventas;";
            }
            else if (opcionSeleccionada == "Cual es el producto mas vendido durante el ultimo mes")
            {
                consultaSQL = "SELECT * FROM most_sold;";
            }
            else
            {
                MessageBox.Show("Seleccione una opción válida.");
                return;
            }

            // 4. Ejecutar la consulta SQL



            using (NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;"))
            {
                conexion.Open(); // Abre la conexión 

                try
                {

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "mueble"
                    using (NpgsqlCommand cmd = new NpgsqlCommand(consultaSQL, conexion))
                    {

                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (opcionSeleccionada == "Cliente que gasto mas en un mes")
                            {
                                richTextBox1.Clear();
                                foreach (DataRow row in dt.Rows)
                                {
                                    richTextBox1.Text += $"ID: {row["id_cliente"]}, NOMBRE: {row["nombre"]}, TOTAL GASTADO: {row["total_gastado"]}\n";
                                }
                            }
                            else if (opcionSeleccionada == "Clientes nuevos (cada mes)")
                            {
                                try
                                {
                                    richTextBox1.Clear();

                                    foreach (DataRow row in dt.Rows)
                                    {
                                        richTextBox1.Text += $"  ID  Cliente: {row["id_cliente"]},    Nombre: {row["nombre"]},    Direccion: {row["direccion"]}, Email:   {row["email"]}, Fecha:   {row["fecha_registro"]}\n";
                                    }
                                }
                                catch
                                {
                                    

                                        MessageBox.Show("No se han registrado nuevos usuarios");

                                    
                                }

                            }
                            else
                            
                            
                            
                            if (opcionSeleccionada == "Cual vendedor realizo más ventas durante el ultimo mes")
                            {
                                richTextBox1.Clear();
                                foreach (DataRow row in dt.Rows)
                                {
                                    richTextBox1.Text += $"ID Vendedor : {row["id_vendedor"]}, Nombre: {row["nombre"]}, Ancho: {row["total_ventas"]}\n";
                                }
                            }
                            else if (opcionSeleccionada == "Cual es el producto mas vendido durante el ultimo mes")
                            {
                                richTextBox1.Clear();
                                foreach (DataRow row in dt.Rows)
                                {
                                    richTextBox1.Text += $"ID Mueble: {row["id_mueble"]}, Nombre: {row["nombre"]}, Precio: {row["precio"]}, Stock: {row["stock"]}, Total vendido: {row["total_vendidos"]}\n";
                                }
                            }

                            // 6. Itera a través de las filas de la tabla y agrega la información al RichTextBox

                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error en la consulta: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
