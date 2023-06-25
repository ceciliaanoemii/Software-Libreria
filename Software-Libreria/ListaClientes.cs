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
    public partial class ListaClientes : Form
    {
        List<VentanaCliente> clientes;
        public ListaClientes(List<VentanaCliente> cli)
        {
            InitializeComponent();
            this.clientes = cli;
        }

        public void mostrarCliente(List<VentanaCliente> clientes)
        {

            foreach (var item in clientes)
            {
                int i = dataGridListClientes.Rows.Add();
                dataGridListClientes.Rows[i].Cells[0].Value = item.getDni();
                dataGridListClientes.Rows[i].Cells[1].Value = item.getNombre();
                dataGridListClientes.Rows[i].Cells[2].Value = item.getTelefono();

            }
        }
        public List<VentanaCliente> BuscarCLiente()
        {
            if (txtdni.Text.Trim() != string.Empty)
            {
                List<VentanaCliente> clientesEncontrados = clientes.FindAll(cliente => cliente.getDni().Equals(txtdni.Text));
                dataGridListClientes.Rows.Clear();
                return clientesEncontrados;

            }
            else
            {
                dataGridListClientes.Rows.Clear();
                return clientes;
            }
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            mostrarCliente(BuscarCLiente());
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            mostrarCliente(clientes);
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
