using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Libreria
{
    public partial class WindowDashboard : Form
    {
        string nombre_vendedor;
        string contrasenia_vendedor;
        List<VentanaLibros> lista_libros = new List<VentanaLibros>();
        public WindowDashboard(string usuario, string contrasenia)
        {
            InitializeComponent();
            nombre_vendedor = usuario;
            contrasenia_vendedor = contrasenia;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowDashboard_Load(object sender, EventArgs e)
        {
            label1.Text += nombre_vendedor;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            using (VentanaLibros ventanaLibros = new VentanaLibros(lista_libros))
                ventanaLibros.ShowDialog();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            using (RegistroDeVenta VentanaVenta = new RegistroDeVenta())
                VentanaVenta.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            using (VentanaCliente ventanaClientes = new VentanaCliente())
                ventanaClientes.ShowDialog();
        }
    }
}
