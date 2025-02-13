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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bases_de_datos
{
    public partial class Ventanaventaagregar : Form
    {
        public Ventanaventaagregar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventanaventa ventanaventa = new Ventanaventa();
            ventanaventa.Show();
            this.Hide();
        }




        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        decimal subtotal = 0;

        private void button1_Click(object sender, EventArgs e)

        {
            int.TryParse(textBox5.Text, out int idmueble);
            int.TryParse(textBox6.Text, out int cantidad);

            DateTime fechaActual = DateTime.Now; // Obtiene la fecha y hora actual
            string fechaTexto = fechaActual.ToShortDateString(); // Convierte la fecha a formato corto


            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexión
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexión
                    conn.Open();

                    // 4. Crea el comando SQL para seleccionar todos los datos de la tabla "color"
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT m.precio  FROM mueble m where m.id_mueble = @id_mueble", conn))
                    {
                        cmd.Parameters.AddWithValue("@id_mueble", idmueble);


                        // 5. Ejecuta el comando y crea un objeto DataTable para almacenar los resultados
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // 6. Itera a través de las filas de la tabla y agrega la información al Label
                            foreach (DataRow row in dt.Rows)
                            {
                                // Obtén el precio y la cantidad (asegúrate de que cantidad esté definida)
                                int precio = Convert.ToInt32(row["precio"]);
                                int cantidad1 = cantidad; // Reemplaza con la cantidad real

                                // Calcula el subtotal
                                subtotal = precio * cantidad1;

                                label3.Text += $"Precio unitario: {precio}, subtotal: {subtotal}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 7. Muestra un mensaje de error si la conexión falla
                    MessageBox.Show("Error al mostrar el subtotal: no hay inventario suficiente ");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now; // Obtiene la fecha y hora actual
            string fechaTexto = fechaActual.ToShortDateString(); // Convierte la fecha a formato corto
            label4.Text = fechaTexto;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //BOTON GENERAR VENTA////////////////////////////////////////////////////////////////////////////////////////////////////
        {

            // 1. Obtener los valores de los controles
            int idmueble = int.Parse(textBox5.Text); // txtIdMueble: TextBox para ID Mueble
            int cantidad = int.Parse(textBox6.Text); // txtCantidad: TextBox para Cantidad
            int idVendedor = int.Parse(textBox8.Text); // txtIdVendedor: TextBox para ID Vendedor
            DateTime fecha = dateTimePicker1.Value; // dtpFecha: DateTimePicker para Fecha
            string medio_pago = comboBox1.Text;

            // 2. Calcular el subtotal (si no se proporciona directamente)


            // 3. Insertar la venta en la base de datos
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;"; // Reemplaza con tu cadena de conexión

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlTransaction transaction = conn.BeginTransaction(); // Iniciar transacción

                try
                {
                    // Insertar en la tabla venta

                    string sqlVenta = "INSERT INTO venta (id_cliente, id_vendedor, fecha,total) VALUES (@idCliente, @idVendedor, @fecha,@total) RETURNING id_venta";
                    long idVenta = 0;

                    using (NpgsqlCommand cmdVenta = new NpgsqlCommand(sqlVenta, conn))
                    {
                        // Asumiendo que tienes un TextBox llamado txtIdCliente para el ID del cliente
                        cmdVenta.Parameters.AddWithValue("@idCliente", int.Parse(textBox1.Text));
                        cmdVenta.Parameters.AddWithValue("@idVendedor", idVendedor);
                        cmdVenta.Parameters.AddWithValue("@fecha", fecha);
                        cmdVenta.Parameters.AddWithValue("@total", subtotal);

                        idVenta = (long?)cmdVenta.ExecuteScalar() ?? -1; // Usar -1 como valor predeterminado

                        if (idVenta == -1)
                        {
                            // Manejar el caso en que no se encontró ninguna venta o el ID es nulo
                            MessageBox.Show("No se pudo obtener el ID de la venta.");
                            return; // Salir del método
                        }
                    }

                    // Insertar en la tabla mueble_venta
                    string sqlDetalle = "INSERT INTO mueble_venta (id_venta, id_mueble, cantidad, subtotal) VALUES (@idVenta, @idmueble, @cantidad, @subtotal)";

                    using (NpgsqlCommand cmdDetalle = new NpgsqlCommand(sqlDetalle, conn))
                    {
                        cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@idmueble", idmueble);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    string sqlpago = "INSERT INTO pago (id_venta, medio_pago, monto) VALUES (@idVenta,@mediopago, @subtotal)";

                    using (NpgsqlCommand cmdDetalle = new NpgsqlCommand(sqlpago, conn))
                    {
                        cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@mediopago", medio_pago);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Confirmar la transacción
                    MessageBox.Show("Venta guardada exitosamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Revertir la transacción en caso de error
                    MessageBox.Show("Error al guardar la venta: " + ex.Message);
                }
            }




        }

        private void Ventanaventaagregar_Load(object sender, EventArgs e)
        {

        }
        /*// 1. Obtener datos de la venta
int idCliente = int.Parse(txtIdCliente.Text); // Reemplaza con el control adecuado
int idVendedor = int.Parse(txtIdVendedor.Text); // Reemplaza con el control adecuado
DateTime fecha = dtpFecha.Value; // Reemplaza con el control DateTimePicker

// 2. Iniciar transacción
using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
{
   conn.Open();
   using (NpgsqlTransaction transaction = conn.BeginTransaction())
   {
       try
       {
           // 3. Insertar venta
           int idVenta = InsertarVenta(conn, transaction, idCliente, idVendedor, fecha);

           // 4. Insertar muebles vendidos
           InsertarMueblesVendidos(conn, transaction, idVenta);

           // 5. Insertar pago
           InsertarPago(conn, transaction, idVenta);

           // 6. Confirmar transacción
           transaction.Commit();
           MessageBox.Show("Venta registrada correctamente.");
       }
       catch (Exception ex)
       {
           // 7. Revertir transacción en caso de error
           transaction.Rollback();
           MessageBox.Show("Error al registrar venta: " + ex.Message);
       }
   }
}
}

private int InsertarVenta(NpgsqlConnection conn, NpgsqlTransaction transaction, int idCliente, int idVendedor, DateTime fecha)
{
using (NpgsqlCommand cmdVenta = new NpgsqlCommand("INSERT INTO venta (id_cliente, id_vendedor, fecha) VALUES (@idCliente, @idVendedor, @fecha) RETURNING id_venta", conn, transaction))
{
   cmdVenta.Parameters.AddWithValue("@idCliente", idCliente);
   cmdVenta.Parameters.AddWithValue("@idVendedor", idVendedor);
   cmdVenta.Parameters.AddWithValue("@fecha", fecha);

   return (int)cmdVenta.ExecuteScalar();
}
}

private void InsertarMueblesVendidos(NpgsqlConnection conn, NpgsqlTransaction transaction, int idVenta)
{
foreach (DataGridViewRow row in dgvMuebles.Rows) // Reemplaza dgvMuebles con tu DataGridView
{
   // Verifica si la fila está vacía
   if (row.IsNewRow) continue;

   int idMueble = int.Parse(row.Cells["id_mueble"].Value.ToString()); // Reemplaza "id_mueble" con el nombre de la columna
   int cantidad = int.Parse(row.Cells["cantidad"].Value.ToString()); // Reemplaza "cantidad" con el nombre de la columna
   decimal subtotal = decimal.Parse(row.Cells["subtotal"].Value.ToString()); // Reemplaza "subtotal" con el nombre de la columna

   using (NpgsqlCommand cmdMuebleVenta = new NpgsqlCommand("INSERT INTO mueble_venta (id_venta, id_mueble, cantidad, subtotal) VALUES (@idVenta, @idMueble, @cantidad, @subtotal)", conn, transaction))
   {
       cmdMuebleVenta.Parameters.AddWithValue("@idVenta", idVenta);
       cmdMuebleVenta.Parameters.AddWithValue("@idMueble", idMueble);
       cmdMuebleVenta.Parameters.AddWithValue("@cantidad", cantidad);
       cmdMuebleVenta.Parameters.AddWithValue("@subtotal", subtotal);

       cmdMuebleVenta.ExecuteNonQuery();
   }
}
}

private void InsertarPago(NpgsqlConnection conn, NpgsqlTransaction transaction, int idVenta)
{
string medioPago = txtMedioPago.Text; // Reemplaza con el control adecuado
decimal total = decimal.Parse(txtTotal.Text); // Reemplaza con el control adecuado

using (NpgsqlCommand cmdPago = new NpgsqlCommand("INSERT INTO pago (id_venta, medio_pago, total) VALUES (@idVenta, @medioPago, @total)", conn, transaction))
{
   cmdPago.Parameters.AddWithValue("@idVenta", idVenta);
   cmdPago.Parameters.AddWithValue("@medioPago", medioPago);
   cmdPago.Parameters.AddWithValue("@total", total);

   cmdPago.ExecuteNonQuery();
}*/
    }
}
    /*private void InsertarPago(NpgsqlConnection conn, NpgsqlTransaction transaction, int idVenta)
        {
            string medioPago = txtMedioPago.Text; // Reemplaza con el control adecuado
            decimal total = decimal.Parse(txtTotal.Text); // Reemplaza con el control adecuado

            using (NpgsqlCommand cmdPago = new NpgsqlCommand("INSERT INTO pago (id_venta, medio_pago, total) VALUES (@idVenta, @medioPago, @total)", conn, transaction))
            {
                cmdPago.Parameters.AddWithValue("@idVenta", idVenta);
                cmdPago.Parameters.AddWithValue("@medioPago", medioPago);
                cmdPago.Parameters.AddWithValue("@total", total);

                cmdPago.ExecuteNonQuery();
            }
        }*/
    /*private int InsertarVenta(NpgsqlConnection conn, NpgsqlTransaction transaction, int idCliente, int idVendedor, DateTime fecha)
        {
            using (NpgsqlCommand cmdVenta = new NpgsqlCommand("INSERT INTO venta (id_cliente, id_vendedor, fecha) VALUES (@idCliente, @idVendedor, @fecha) RETURNING id_venta", conn, transaction))
            {
                cmdVenta.Parameters.AddWithValue("@idCliente", idCliente);
                cmdVenta.Parameters.AddWithValue("@idVendedor", idVendedor);
                cmdVenta.Parameters.AddWithValue("@fecha", fecha);

                return (int)cmdVenta.ExecuteScalar();
            }
        }*/

    /*private void InsertarMueblesVendidos(NpgsqlConnection conn, NpgsqlTransaction transaction, int idVenta)
    {
        foreach (DataGridViewRow row in dgvMuebles.Rows) // Reemplaza dgvMuebles con tu DataGridView
        {
            // Verifica si la fila está vacía
            if (row.IsNewRow) continue;

            int idMueble = int.Parse(row.Cells["id_mueble"].Value.ToString()); // Reemplaza "id_mueble" con el nombre de la columna
            int cantidad = int.Parse(row.Cells["cantidad"].Value.ToString()); // Reemplaza "cantidad" con el nombre de la columna
            decimal subtotal = decimal.Parse(row.Cells["subtotal"].Value.ToString()); // Reemplaza "subtotal" con el nombre de la columna

            using (NpgsqlCommand cmdMuebleVenta = new NpgsqlCommand("INSERT INTO mueble_venta (id_venta, id_mueble, cantidad, subtotal) VALUES (@idVenta, @idMueble, @cantidad, @subtotal)", conn, transaction))
            {
                cmdMuebleVenta.Parameters.AddWithValue("@idVenta", idVenta);
                cmdMuebleVenta.Parameters.AddWithValue("@idMueble", idMueble);
                cmdMuebleVenta.Parameters.AddWithValue("@cantidad", cantidad);
                cmdMuebleVenta.Parameters.AddWithValue("@subtotal", subtotal);

                cmdMuebleVenta.ExecuteNonQuery();
            }
        }
    }*/


    /*{
        // 1. Obtener datos del formulario
        int.TryParse(textBox5.Text, out int idmueble);
        int.TryParse(textBox6.Text, out int cantidad);
        int.TryParse(textBox8.Text, out int idvendedor);
        DateTime fechaRegistro = DateTime.Parse(textBox7.Text);


        // 2. Insertar cliente y obtener ID
        int idventa = InsertarVenta(fecha);

        if (idventa > 0)
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
    }*

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
    }*/

