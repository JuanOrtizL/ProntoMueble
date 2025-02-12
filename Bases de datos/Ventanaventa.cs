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
    public partial class Ventanaventa : Form
    {
        public Ventanaventa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal Principal = new Principal();
            this.Hide();
            Principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanaventabuscar ventanaventabuscar = new Ventanaventabuscar();
            ventanaventabuscar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanaventaagregar ventanaventaagregar = new Ventanaventaagregar();
            ventanaventaagregar.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
