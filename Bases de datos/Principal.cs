using Npgsql;

namespace Bases_de_datos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanaventa Ventanaventa = new Ventanaventa(); // Crea una instancia del formulario de venta
            this.Hide();
            Ventanaventa.Show(); // Abre el formulario de venta
        }


        private void button3_Click(object sender, EventArgs e)
        {

            Ventanacliente ventanaClientes = new Ventanacliente();
            this.Hide();
            ventanaClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventanainventario ventanaInventario = new Ventanainventario();
            this.Hide();
            ventanaInventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventanavendedores ventanavendedores = new Ventanavendedores();
            this.Hide();
            ventanavendedores.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=prontomueble;User Id=postgres;Password=12345;";

            // 2. Crea la conexi�n
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // 3. Abre la conexi�n
                    conn.Open();

                    // 4. Muestra un mensaje de �xito
                    MessageBox.Show("Conexi�n exitosa a la base de datos.");

                    // 5. Cierra la conexi�n (se cierra autom�ticamente al salir del bloque "using")
                }
                catch (Exception ex)
                {
                    // 6. Muestra un mensaje de error
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }
    }
}
