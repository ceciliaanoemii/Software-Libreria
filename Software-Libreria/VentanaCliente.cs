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
    public partial class VentanaCliente : Form
    {
        private string nombre;
        private string dni;
        private string telefono;
        List<VentanaCliente> lista_clientes;
        public VentanaCliente( string dni, string nombre, string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;

            InitializeComponent();
        }

        public VentanaCliente()
        {
            InitializeComponent();

        }

        public VentanaCliente(List<VentanaCliente> lista_)
        {
            InitializeComponent();
            this.lista_clientes = lista_;
        }
        public void setTodo(string dni, string nom, string tel)
        {
            this.dni = dni;
            this.nombre = nom;
            this.telefono = tel;
        }

        private void VentanaCliente_Load(object sender, EventArgs e)
        {

        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getDni()
        {
            return this.dni;
        }
        public string getTelefono()
        {
            return this.telefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RegistroCliente ventanaRegistroCliente = new RegistroCliente(lista_clientes))
                ventanaRegistroCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaClientes cli = new ListaClientes(lista_clientes);
            cli.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
