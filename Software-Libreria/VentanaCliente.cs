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
        string nombre;
        int edad;
        string dni;
        string telefono;
        List<VentanaCliente> clientes;

        public VentanaCliente(IContainer components, string nombre, int edad, string dni, string telefono)
        {
            this.components = components;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.telefono = telefono;

            InitializeComponent();
        }

        public VentanaCliente()
        {
            InitializeComponent();

        }

        private void VentanaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
