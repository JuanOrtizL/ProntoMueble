using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases_de_datos
{
    public partial class Ventanainventario : Form
    {
        public Ventanainventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanainventarioagregar ventanainventarioagregar = new Ventanainventarioagregar();
            ventanainventarioagregar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Principal Principal = new Principal();
            this.Hide();
            Principal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventanainvntarioproveedor ventanainvntarioproveedor = new Ventanainvntarioproveedor();
            ventanainvntarioproveedor.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaInventarioinventario ventanaInventarioinventario = new VentanaInventarioinventario();
            this.Hide();
            ventanaInventarioinventario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
